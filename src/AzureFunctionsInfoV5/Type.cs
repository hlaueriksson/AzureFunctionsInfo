using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfoV5
{
    public static class Type
    {
        [Function("Type")]
        public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req, FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Type");

            var query = HttpUtility.ParseQueryString(req.Url.Query);
            var fullName = query["FullName"];
            var name = query["Name"];

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, req, logger);

            if (!string.IsNullOrEmpty(name)) return ByName(name, req, logger);

            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        private static HttpResponseData ByFullName(string fullName, HttpRequestData req, ILogger logger)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            logger.LogInformation($"{fullName} was found in {result.Count} assemblies");

            if (result.Any())
            {
                var response = req.CreateResponse();
                response.WriteAsJsonAsync(result);
                return response;
            }

            return req.CreateResponse(HttpStatusCode.NotFound);
        }

        private static HttpResponseData ByName(string name, HttpRequestData req, ILogger logger)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            logger.LogInformation($"{name} matched {result.Count} types");

            if (result.Any())
            {
                var response = req.CreateResponse();
                response.WriteAsJsonAsync(result);
                return response;
            }

            return req.CreateResponse(HttpStatusCode.NotFound);
        }

        private static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
        {
            using var enumerator = values.GetEnumerator();
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