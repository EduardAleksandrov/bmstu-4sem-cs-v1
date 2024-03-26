using System.Diagnostics;

namespace IoC_Containers;

public class HttpClient : IHttpClient
{
    private readonly ILogger _logger;

    public HttpClient(ILogger logger)
    {
        _logger = logger;
    }
    public HttpResponseMessage Get(string url)
    {
        throw new NotImplementedException();
    }
}
