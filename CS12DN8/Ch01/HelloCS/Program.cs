ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

string name = typeof(Program).Namespace ?? "None!";
WriteLine($"Namespace: {name}");

WriteLine("We received {0} arguments:", args.Length);
foreach (string arg in args)
{
    WriteLine(arg);
}

WriteLine("CurrentDirectory: {0}", Env.CurrentDirectory);
WriteLine("OSVersion.VersionString: {0}", Env.OSVersion.VersionString);

ResetColor();

throw new Exception();

