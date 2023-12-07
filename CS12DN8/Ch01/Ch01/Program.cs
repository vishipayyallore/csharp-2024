using Ch01.Extensions;
using Ch01.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost? host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

// Get IRunnableManager from the service provider
IRunnableManager? runnableManager = host.Services.GetRequiredService<IRunnableManager>();

// Discover and instantiate IRunnable instances in the Runnables namespace
IEnumerable<IRunnable?>? runnableInstances = runnableManager.GetRunnableInstances("Ch01.Runnables");

foreach (IRunnable? runnable in runnableInstances!)
{
    runnableManager.RunRunnable(runnable!);
}

WriteLine("\n\nPress any key ... ");
ReadKey();
