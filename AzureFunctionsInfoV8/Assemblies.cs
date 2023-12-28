using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfoV8
{
    public class Assemblies
    {
        private readonly ILogger _logger;

        public Assemblies(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Assemblies>();
        }

        [Function("Assemblies")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var result = assemblies.Except(new[] { typeof(Assemblies).Assembly }).OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

            _logger.LogInformation("{Count} assemblies found", assemblies.Length);

            var response = req.CreateResponse();
            response.WriteAsJsonAsync(result);

            return response;
        }
    }
}
