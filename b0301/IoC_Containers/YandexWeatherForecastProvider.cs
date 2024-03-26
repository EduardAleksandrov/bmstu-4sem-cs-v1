namespace IoC_Containers;

public class YandexWeatherForecastProvider:IWeatherForecastsProvider
{
    private readonly IHttpClient _httpClient;
    private readonly ILogger _logger;

    public YandexWeatherForecastProvider(IHttpClient httpClient, ILogger logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
}
