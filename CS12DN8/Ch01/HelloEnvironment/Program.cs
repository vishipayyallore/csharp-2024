namespace HelloEnvironment;

class Program
{
    static void Main(string[] args)
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine("We received {0} arguments:", args.Length);
        foreach (var arg in args)
        {
            WriteLine(arg);
        }

        WriteLine("CurrentDirectory: {0}", Env.CurrentDirectory);
        WriteLine("OSVersion.VersionString: {0}", Env.OSVersion.VersionString);
        WriteLine("Namespace: {0}!", typeof(Program).Namespace);

        ResetColor();

        WriteLine("Press any key ...");
        ReadKey();
    }
}