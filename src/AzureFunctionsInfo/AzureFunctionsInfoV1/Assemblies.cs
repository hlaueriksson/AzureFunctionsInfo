using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionsInfoV1
{
    public static class Assemblies
    {
        [FunctionName("Assemblies")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var result = assemblies.OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

            log.Info($"{assemblies.Length} assemblies found");

            return req.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}