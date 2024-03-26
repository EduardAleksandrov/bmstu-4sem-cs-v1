namespace IoC_Containers;

public class GismeteoWeatherForecastProvider:IWeatherForecastsProvider
{
    private readonly IHttpClient _httpClient;
    private readonly ILogger _logger;

    public GismeteoWeatherForecastProvider(IHttpClient httpClient, ILogger logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
}
