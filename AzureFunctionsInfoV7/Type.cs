using System.Net;
using System.Web;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfoV7
{
    public class Type
    {
        private readonly ILogger _logger;

        public Type(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Type>();
        }

        [Function("Type")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var query = HttpUtility.ParseQueryString(req.Url.Query);
            var fullName = query["FullName"];
            var name = query["Name"];

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, req);

            if (!string.IsNullOrEmpty(name)) return ByName(name, req);

            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        private HttpResponseData ByFullName(string fullName, HttpRequestData req)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            _logger.LogInformation($"{fullName} was found in {result.Count} assemblies");

            if (result.Any())
            {
                var response = req.CreateResponse();
                response.WriteAsJsonAsync(result);
                return response;
            }

            return req.CreateResponse(HttpStatusCode.NotFound);
        }

        private HttpResponseData ByName(string name, HttpRequestData req)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            _logger.LogInformation($"{name} matched {result.Count} types");

            if (result.Any())
            {
                var response = req.CreateResponse();
                response.WriteAsJsonAsync(result);
                return response;
            }

            return req.CreateResponse(HttpStatusCode.NotFound);
        }
    }

    internal static class EnumerableExtensions
    {
        internal static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
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
