using CoreServices.Runner.Interfaces;

namespace Ch02.Runnables;

internal class StringsDemoApp : IRunnable
{
    public string Title => "Strings Demo, C# 12 - .Net 8";

    public void Run()
    {
        string horizontalLine = new('-', count: 74); // 74 hyphens.
        WriteLine(horizontalLine);
    }
}
