using Ch01.Interfaces;

namespace Ch01.Runnables;

internal class HelloEnvironmentApp : IRunnable
{
    public void Run()
    {
        WriteLine("HelloEnvironmentApp::Run() Called.");
    }

    public void Run(bool throwException)
    {
        WriteLine("HelloEnvironmentApp::Run(bool throwException) Called.");
    }
}
