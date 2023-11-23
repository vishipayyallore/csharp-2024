namespace HelloEnvironment;

class Program
{
    static void Main(string[] args)
    {
        ForegroundColor = ConsoleColor.DarkCyan;

        WriteLine(Env.CurrentDirectory);
        WriteLine(Env.OSVersion.VersionString);
        WriteLine("Namespace: {0}!", typeof(Program).Namespace);

        ResetColor();

        WriteLine("Press any key ...");
        ReadKey();
    }
}