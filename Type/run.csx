using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, string name, TraceWriter log)
{
    var result = System.AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(x => x.GetTypes())
                    .SkipExceptions()
                    .Where(x => x.FullName == name)
                    .Select(x => x.Assembly.ToString())
                    .ToList();

    log.Info($"{name} was found in {result.Count()} assemblies");

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