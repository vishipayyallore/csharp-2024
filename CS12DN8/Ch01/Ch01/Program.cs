using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Ch01.Extensions;
using Ch01.Interfaces;

using IHost? host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

host.Services.GetRequiredService<IRunnable>()?.Run();

WriteLine("\n\nPress any key ... ");
ReadKey();