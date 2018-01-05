using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionsInfoV2
{
    public static class Type
    {
        [FunctionName("Type")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            var fullName = req.Query.Keys.FirstOrDefault(q => string.Compare(q, "FullName", StringComparison.OrdinalIgnoreCase) == 0);
            var name = req.Query.Keys.FirstOrDefault(q => string.Compare(q, "Name", StringComparison.OrdinalIgnoreCase) == 0);

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, log);

            if (!string.IsNullOrEmpty(name)) return ByName(name, log);

            return new BadRequestResult();
        }

        private static IActionResult ByFullName(string fullName, TraceWriter log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            log.Info($"{fullName} was found in {result.Count} assemblies");

            if (result.Any()) return new OkObjectResult(result);

            return new NotFoundResult();
        }

        private static IActionResult ByName(string name, TraceWriter log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            log.Info($"{name} matched {result.Count} types");

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