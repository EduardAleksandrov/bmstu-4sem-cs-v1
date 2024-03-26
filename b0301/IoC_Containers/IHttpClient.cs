namespace IoC_Containers;

public interface IHttpClient
{
    HttpResponseMessage Get(string url);
}
