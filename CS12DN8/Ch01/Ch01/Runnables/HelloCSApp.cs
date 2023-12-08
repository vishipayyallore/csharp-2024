using Ch01.Interfaces;
using HeaderFooter;
using HeaderFooter.Interfaces;

namespace Ch01.Runnables;

internal class HelloCSApp : IRunnable
{
    public string Title => "Hello, C# 12 - .Net 8";

    public void Run()
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("Hello, C# 12, and DotNet 8 !");

        string name = typeof(Program).Namespace ?? "None!";
        WriteLine($"Namespace: {name}");
    }

}
