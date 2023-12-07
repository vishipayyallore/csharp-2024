namespace Ch01.Interfaces;

public interface IRunnableManager
{
    IEnumerable<IRunnable?> GetRunnableInstances(string namespacePrefix);

    void RunRunnable(IRunnable runnable);
}