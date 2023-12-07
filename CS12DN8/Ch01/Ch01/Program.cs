using Ch01.Extensions;
using Ch01.Interfaces;
using Microsoft.Extensions.Hosting;
using System.Reflection;

using IHost? host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

// Discover and instantiate IRunnable instances in the Runnables namespace
IEnumerable<IRunnable?>? runnableInstances = GetRunnableInstances("Ch01.Runnables");

foreach (IRunnable? runnable in runnableInstances!)
{
    RunRunnable(runnable!);
}

WriteLine("\n\nPress any key ... ");
ReadKey();

static IEnumerable<IRunnable?>? GetRunnableInstances(string namespacePrefix)
{
    Type? runnableInterfaceType = typeof(IRunnable);
    Assembly? assembly = Assembly.GetExecutingAssembly();

    List<IRunnable?>? runnableInstances = assembly.GetTypes()
        .Where(type => type.IsClass && type.Namespace == namespacePrefix && runnableInterfaceType.IsAssignableFrom(type))
        .Select(type => (IRunnable?)Activator.CreateInstance(type))
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
        WriteLine($"An error occurred while running {runnable.GetType().Name}: {ex.Message}");
    }
}