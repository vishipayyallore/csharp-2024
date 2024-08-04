// File: Program.cs

int[] numbers = [1, 2, 3, 4, 5];

ApproachableDemo(args);

SumNumbersDemo1(numbers);

static void ApproachableDemo(string[] values)
{
    WriteLine("Showing Approachable Demo");

    if (values.Length == 0)
    {
        WriteLine("No arguments were provided.");
        return;
    }

    for (int n = 0; n < values.Length; n++)
    {
        WriteLine("arg[{0}] = {1}", n, values[n]);
    }

}

static void SumNumbersDemo1(int[] numbers)
{
    WriteLine("Showing Sum Numbers Demo 1");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    WriteLine("Sum of numbers: {0}", sum);
}

