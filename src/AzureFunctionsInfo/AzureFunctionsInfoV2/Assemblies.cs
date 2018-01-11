using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionsInfoV2
{
    public static class Assemblies
    {
        [FunctionName("Assemblies")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequest req, TraceWriter log)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var result = assemblies.Except(new[] { typeof(Assemblies).Assembly }).OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

            log.Info($"{assemblies.Length} assemblies found");

            return new OkObjectResult(result);
        }
    }
}