using System.Net;
using System.Web;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfo
{
    public class Types(ILoggerFactory loggerFactory)
    {
        private readonly ILogger _logger = loggerFactory.CreateLogger<Types>();

        [Function(nameof(Types))]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var query = HttpUtility.ParseQueryString(req.Url.Query);
            var fullName = query["FullName"];
            var name = query["Name"];

            if (!string.IsNullOrEmpty(fullName)) return await ByFullNameAsync(fullName, req);

            if (!string.IsNullOrEmpty(name)) return await ByNameAsync(name, req);

            return req.CreateResponse(HttpStatusCode.BadRequest);
        }

        private async Task<HttpResponseData> ByFullNameAsync(string fullName, HttpRequestData req)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            _logger.LogInformation("{FullName} was found in {Count} assemblies", fullName, result.Count);

            if (result.Count != 0)
            {
                var response = req.CreateResponse();
                await response.WriteAsJsonAsync(result);
                return response;
            }

            return req.CreateResponse(HttpStatusCode.NotFound);
        }

        private async Task<HttpResponseData> ByNameAsync(string name, HttpRequestData req)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            _logger.LogInformation("{Name} matched {Count} types", name, result.Count);

            if (result.Count != 0)
            {
                var response = req.CreateResponse();
                await response.WriteAsJsonAsync(result);
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
