using CoreServices.Runner.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Ch02.Extensions;

public static class ServiceCollectionExtensions
{

    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        _ = services.ConfigureRunnerServices();

        // IMPORTANT! Register the application entry point
        //_ = services.AddKeyedTransient<IRunnable, HelloCSApp>("HelloCSApp");

        return services;
    }

}
