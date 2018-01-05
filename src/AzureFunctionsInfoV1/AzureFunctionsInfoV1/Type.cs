using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionsInfoV1
{
    public static class Type
    {
        [FunctionName("Type")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var fullName = req.GetQueryNameValuePairs().FirstOrDefault(q => string.Compare(q.Key, "FullName", StringComparison.OrdinalIgnoreCase) == 0).Value;
            var name = req.GetQueryNameValuePairs().FirstOrDefault(q => string.Compare(q.Key, "Name", StringComparison.OrdinalIgnoreCase) == 0).Value;

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, req, log);

            if (!string.IsNullOrEmpty(name)) return ByName(name, req, log);

            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        private static HttpResponseMessage ByFullName(string fullName, HttpRequestMessage req, TraceWriter log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            log.Info($"{fullName} was found in {result.Count} assemblies");

            return result.Any() ? req.CreateResponse(HttpStatusCode.OK, result) : req.CreateResponse(HttpStatusCode.NotFound);
        }

        private static HttpResponseMessage ByName(string name, HttpRequestMessage req, TraceWriter log)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            log.Info($"{name} matched {result.Count} types");

            return result.Any() ? req.CreateResponse(HttpStatusCode.OK, result) : req.CreateResponse(HttpStatusCode.NotFound);
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