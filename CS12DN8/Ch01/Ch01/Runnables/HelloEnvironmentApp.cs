using Ch01.Interfaces;
using HeaderFooter;
using HeaderFooter.Interfaces;

namespace Ch01.Runnables;

internal class HelloEnvironmentApp(IHeader header, IFooter footer) : IRunnable
{

    private readonly IHeader _header = header ?? throw new ArgumentNullException(nameof(header));
    private readonly IFooter _footer = footer ?? throw new ArgumentNullException(nameof(footer));

    public HelloEnvironmentApp() : this(new Header(), new Footer())
    {
    }

    public void Run()
    {
        _header.DisplayHeader('=', "Hello, Environment");

        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("CurrentDirectory: {0}", Env.CurrentDirectory);
        WriteLine("OSVersion.VersionString: {0}", Env.OSVersion.VersionString);
        WriteLine("Namespace: {0}!", typeof(Program).Namespace);

        _footer.DisplayFooter('-');
    }

}
