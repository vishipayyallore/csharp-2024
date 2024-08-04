// File: Program.cs

using PointLib;

int[] numbers = [1, 2, 3, 4, 5];

ApproachableDemo(args);

SumNumbersDemo1(numbers);

UsePointStructure();

static void ApproachableDemo(string[] values)
{
    WriteLine("\nShowing Approachable Demo");

    if (values.Length == 0)
    {
        WriteLine("No arguments were provided.");
        return;
    }

    // Safety feature of C# to avoid IndexOutOfRangeException
    for (int n = 0; n < values.Length; n++)
    {
        WriteLine("arg[{0}] = {1}", n, values[n]);
    }

}

static void SumNumbersDemo1(int[] numbers)
{
    WriteLine("\nShowing Sum Numbers Demo 1");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    WriteLine("Sum of numbers: {0}", sum);
}

static void UsePointStructure()
{
    WriteLine("\nShowing Use Point 2D OR 3D Demo");

    // Resilient feature of C# to changes in PointLib
    Point point = new()
    {
        X = 10,
        Y = 20
    };

    WriteLine("Point: {0}", point);
}