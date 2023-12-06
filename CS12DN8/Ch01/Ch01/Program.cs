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

IRunnable? runnable = host.Services.GetKeyedService<IRunnable>("HelloCSApp");

if (runnable != null)
{
    try
    {
        runnable.Run();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
        // Log the exception
    }
}
else
{
    Console.WriteLine("Unable to resolve the IRunnable service with key 'HelloCSApp'.");
}

WriteLine("\n\nPress any key ... ");
ReadKey();