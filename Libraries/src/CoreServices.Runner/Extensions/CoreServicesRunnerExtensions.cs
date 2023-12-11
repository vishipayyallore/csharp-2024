using CoreServices.Runner.Interfaces;
using HeaderFooter;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CoreServices.Runner.Extensions;

public static class CoreServicesRunnerExtensions
{

    public static IServiceCollection ConfigureRunnerServices(this IServiceCollection services)
    {
        _ = services.AddTransient<IFooter, Footer>();
        _ = services.AddTransient<IHeader, Header>();

        _ = services.AddTransient<IRunnableManager, RunnableManager>();

        return services;
    }

}
