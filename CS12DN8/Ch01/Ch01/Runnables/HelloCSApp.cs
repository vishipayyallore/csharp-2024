using Ch01.Interfaces;
using HeaderFooter.Interfaces;

namespace Ch01.Runnables;

internal class HelloCSApp(IHeader header, IFooter footer) : IRunnable
{
    private readonly IHeader _header = header ?? throw new ArgumentNullException(nameof(header));
    private readonly IFooter _footer = footer ?? throw new ArgumentNullException(nameof(footer));

    public void Run()
    {
        _header.DisplayHeader('=', "Hello, C# 12 - .Net 8");

        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("Hello, C# 12, and DotNet 8 !");

        string name = typeof(Program).Namespace ?? "None!";
        WriteLine($"Namespace: {name}");

        _footer.DisplayFooter('-');
    }

    public void Run(bool throwException)
    {
        Run();

        if (throwException) ThrowAndShowExceptionMessage();
    }


    private static void ThrowAndShowExceptionMessage()
    {
        throw new Exception();
    }
}
