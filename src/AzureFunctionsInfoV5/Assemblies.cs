using System;
using System.Linq;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsInfoV5
{
    public static class Assemblies
    {
        [Function("Assemblies")]
        public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req, FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Assemblies");

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var result = assemblies.Except(new[] { typeof(Assemblies).Assembly }).OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

            logger.LogInformation("{Count} assemblies found", assemblies.Length);

            var response = req.CreateResponse();
            response.WriteAsJsonAsync(result);

            return response;
        }
    }
}