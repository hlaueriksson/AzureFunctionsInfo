using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    var fullName = req.GetQueryNameValuePairs().FirstOrDefault(q => string.Compare(q.Key, "FullName", true) == 0).Value;
    var name = req.GetQueryNameValuePairs().FirstOrDefault(q => string.Compare(q.Key, "Name", true) == 0).Value;

    if (!string.IsNullOrEmpty(fullName)) return ByFullName(fullName, req, log);

    if (!string.IsNullOrEmpty(name)) return ByName(name, req, log);

    return req.CreateResponse(HttpStatusCode.BadRequest);
}

public static HttpResponseMessage ByFullName(string fullName, HttpRequestMessage req, TraceWriter log)
{
    var result = System.AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(x => x.GetTypes())
                    .SkipExceptions()
                    .Where(x => x.FullName == fullName)
                    .OrderBy(x => x.Assembly.FullName)
                    .Select(x => x.Assembly.ToString())
                    .ToList();

    log.Info($"{fullName} was found in {result.Count()} assemblies");

    if (result.Any()) return req.CreateResponse(HttpStatusCode.OK, result);

    return req.CreateResponse(HttpStatusCode.NotFound);
}

public static HttpResponseMessage ByName(string name, HttpRequestMessage req, TraceWriter log)
{
    var result = System.AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(x => x.GetTypes())
                    .SkipExceptions()
                    .Where(x => x.Name == name)
                    .OrderBy(x => x.Assembly.FullName)
                    .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                    .ToList();

    log.Info($"{name} matched {result.Count()} types");

    if (result.Any()) return req.CreateResponse(HttpStatusCode.OK, result);

    return req.CreateResponse(HttpStatusCode.NotFound);
}

public static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
{
    using (var enumerator = values.GetEnumerator())
    {
        bool next = true;
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