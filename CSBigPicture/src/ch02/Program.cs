
ShowApproachable(args);

static void ShowApproachable(string[] args)
{
    WriteLine("Showing Approachable Demo");

    if (args.Length == 0)
    {
        WriteLine("No arguments were provided.");
        return;
    }

    for (int n = 0; n < args.Length; n++)
    {
        WriteLine("arg[{0}] = {1}", n, args[n]);
    }

}