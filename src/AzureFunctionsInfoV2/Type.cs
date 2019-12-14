using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfoV2
{
    public static class Type
    {
        [FunctionName("Type")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var fullName = req.Query.FirstOrDefault(q => string.Compare(q.Key, "FullName", StringComparison.OrdinalIgnoreCase) == 0).Value;
            var name = req.Query.FirstOrDefault(q => string.Compare(q.Key, "Name", StringComparison.OrdinalIgnoreCase) == 0).Value;

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, log);

            if (!string.IsNullOrEmpty(name)) return ByName(name, log);

            return new BadRequestResult();
        }

        private static IActionResult ByFullName(string fullName, ILogger log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            log.LogInformation($"{fullName} was found in {result.Count} assemblies");

            if (result.Any()) return new OkObjectResult(result);

            return new NotFoundResult();
        }

        private static IActionResult ByName(string name, ILogger log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            log.LogInformation($"{name} matched {result.Count} types");

            if (result.Any()) return new OkObjectResult(result);

            return new NotFoundResult();
        }

        private static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
        {
            using (var enumerator = values.GetEnumerator())
            {
                var next = true;
                while (next)
                {
                    try
                    {
                        next = enumerator.MoveNext();
                    }
                    catch
                    {
                        continue;
                    }

                    if (next) yield return enumerator.Current;
                }
            }
        }
    }
}