using IoC_Containers;

using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        
        IServiceCollection services = new ServiceCollection();
        services.AddTransient<IWeatherForecastsProvider, GismeteoWeatherForecastProvider>();
        services.AddTransient<IHttpClient, IoC_Containers.HttpClient>();
        services.AddTransient<ILogger, FileLogger>();
        
        var serviceProvider = services.BuildServiceProvider();
        var weatherForecastProvider = serviceProvider.GetService<IWeatherForecastsProvider>();
        
        Console.WriteLine("Hello, World!");
    }
    static void CreateByHand()
    {
        ILogger logger= new FileLogger();
        IHttpClient httpClient = new IoC_Containers.HttpClient(logger);
        IWeatherForecastsProvider weatherForecastProvider  = new GismeteoWeatherForecastProvider(httpClient, logger);
    }
}

