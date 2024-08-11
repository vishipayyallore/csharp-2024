// File: Program.cs

using ch03.Models;

PointV1 ptV1 = new() { Y = 12 };
PointV2 ptV2 = new() { X = 30, Y = 12 }; // What happens if X (or X & Y) are omitted?

WriteLine($"Point V1: {ptV1} \nPoint V2: {ptV2}\n");

ShowCollections();

static void ShowCollections()
{
    string[] stooges3 = ["Moe", "Larry", "Curly"];
    DisplayStrings("C# 12 collection initializer syntax", stooges3);

    string[] twoStooges = ["Moe", "Larry"];
    string[] moreStooges = ["Curly", "Shemp"];
    string[] fourStooges = [.. twoStooges, .. moreStooges];  // Spread operator
    DisplayStrings("C# 12 collection spread operator", fourStooges);
}

static void DisplayStrings(string context, string[] strings)
{
    WriteLine($"{context}:");

    foreach (string s in strings)
    {
        WriteLine(s);
    }

    WriteLine();
}