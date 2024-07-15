using System.Collections;

PrintNames(GenerateNames());

PrintNamesAL(GenerateNamesAL());

static string[] GenerateNames()
{
    return ["Gamma", "Vlissides", "Johnson", "Helm"];
}

static void PrintNames(string[] names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}

static ArrayList GenerateNamesAL()
{
    return ["Gamma", "Vlissides", "Johnson", "Helm"];
}

static void PrintNamesAL(ArrayList names)
{
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
}
