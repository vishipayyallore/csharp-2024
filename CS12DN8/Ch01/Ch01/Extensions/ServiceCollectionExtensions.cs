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

        return services;
    }

}
