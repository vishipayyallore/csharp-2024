using Ch01.Interfaces;
using Ch01.Runnables;
using Ch01.Utilities;
using HeaderFooter;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ch01.Extensions;

public static class ServiceCollectionExtensions
{

    public static IServiceCollection ConfigureServices(this IServiceCollection services)
    {
        _ = services.AddTransient<IFooter, Footer>();
        _ = services.AddTransient<IHeader, Header>();

        _ = services.AddTransient<IRunnableManager, RunnableManager>();

        // IMPORTANT! Register the application entry point
        _ = services.AddKeyedTransient<IRunnable, HelloCSApp>("HelloCSApp");
        _ = services.AddKeyedTransient<IRunnable, HelloEnvironmentApp>("HelloEnvironmentApp");

        return services;
    }

}
