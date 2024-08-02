using UseMathCSService.Services;
/*
    Using VB.NET style namespace aliasing. We are using VB.NET Library in this C# program.
*/
using MathServicesVBLib.MathLibrary;

ForegroundColor = ConsoleColor.Green;

Write("Enter your name: ");
var name = ReadLine();
WriteLine($"Hello {name}!");

MathsSvc maths = new();

WriteLine("Using C# Library");

int num1 = 10, num2 = 20;
WriteLine($"\n{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

WriteLine($"{num1} * {num2} = {maths.MultiplyNumbers(num1, num2)}");

WriteLine($"Max value is {MathsSvc.MaxValue}");

ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;

WriteLine("Using VB.Net Library");

num1 = 10;
num2 = 20; /* Variable declaration and initialization. */
Maths mathsVb = new(); /* Instantiation of Maths class. */
Console.WriteLine($"{num1} + {num2} = {mathsVb.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
Console.WriteLine($"{num1} + {num2} = {Maths.AddNumbersV1(num1, num2)}");
Console.WriteLine($"Max value is {Maths.MaxValue}");

Console.ResetColor();

WriteLine("Press any key to exit.");
ReadKey();
