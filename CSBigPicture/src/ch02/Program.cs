// File: Program.cs

int[] numbers = [1, 2, 3, 4, 5];

ApproachableDemo(args);

SumNumbersDemo1(numbers);

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

static void ApproachableDemo(string[] args)
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