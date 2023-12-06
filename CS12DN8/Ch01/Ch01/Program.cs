using Ch01.Extensions;
using Ch01.Interfaces;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

using IHost? host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

// Discover and instantiate IRunnable instances in the Runnables namespace
var runnableInstances = GetRunnableInstances("Ch01.Runnables");

foreach (var runnable in runnableInstances)
{
    RunRunnable(runnable);
}

WriteLine("\n\nPress any key ... ");
ReadKey();

static IEnumerable<IRunnable> GetRunnableInstances(string namespacePrefix)
{
    var runnableInterfaceType = typeof(IRunnable);
    var assembly = Assembly.GetExecutingAssembly();

    var runnableInstances = assembly.GetTypes()
        .Where(type => type.IsClass && type.Namespace == namespacePrefix && runnableInterfaceType.IsAssignableFrom(type))
        .Select(type => (IRunnable)Activator.CreateInstance(type))
        .ToList();

    return runnableInstances;
}

static void RunRunnable(IRunnable runnable)
{
    try
    {
        runnable.Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred while running {runnable.GetType().Name}: {ex.Message}");
        // Log the exception
    }
}