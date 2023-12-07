using Ch01.Interfaces;
using System.Reflection;

namespace Ch01.Utilities;

public class RunnableManager : IRunnableManager
{

    public IEnumerable<IRunnable?> GetRunnableInstances(string namespacePrefix)
    {
        Type runnableInterfaceType = typeof(IRunnable);
        Assembly assembly = Assembly.GetExecutingAssembly();

        List<IRunnable?> runnableInstances = assembly.GetTypes()
            .Where(type => type.IsClass && type.Namespace == namespacePrefix && runnableInterfaceType.IsAssignableFrom(type))
            .Select(type => (IRunnable?)Activator.CreateInstance(type))
            .ToList();

        return runnableInstances;
    }

    public void RunRunnable(IRunnable runnable)
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
}
