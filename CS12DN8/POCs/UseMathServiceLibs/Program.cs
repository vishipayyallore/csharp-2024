/*
    Using VB.NET style namespace aliasing. We are using VB.NET Library in this C# program.
*/
using MathServicesCSLib;

ForegroundColor = ConsoleColor.Green;

Write("Enter your name: ");
var name = ReadLine();
WriteLine($"Hello {name}!");

MathsCSSvc maths = new();

WriteLine("\nUsing C# Library");

int num1 = 10, num2 = 20;
WriteLine($"{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

WriteLine($"{num1} * {num2} = {maths.MultiplyNumbers(num1, num2)}");

WriteLine($"Max value is {MathsCSSvc.MaxValue}");

ResetColor();

ForegroundColor = ConsoleColor.Yellow;

WriteLine("\nUsing VB.Net Library");

num1 = 10;
num2 = 20; /* Variable declaration and initialization. */
MathsVBSvc mathsVb = new(); /* Instantiation of Maths class. */
WriteLine($"{num1} + {num2} = {mathsVb.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
WriteLine($"{num1} + {num2} = {MathsVBSvc.AddNumbersV1(num1, num2)}");
WriteLine($"Max value is {MathsVBSvc.MaxValue}");

ResetColor();

WriteLine("Press any key to exit.");
ReadKey();
