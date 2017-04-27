using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var assemblies = System.AppDomain.CurrentDomain.GetAssemblies();
    var result = assemblies.Select(x => x.ToString());

    log.Info($"{assemblies.Count()} assemblies found");

    return req.CreateResponse(HttpStatusCode.OK, result);
}