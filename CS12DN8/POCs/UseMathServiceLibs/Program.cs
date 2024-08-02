/*
    Using VB.NET style namespace aliasing. We are using VB.NET Library in this C# program.
*/
using MathServicesCSLib;
using MathServicesVBLib.MathLibrary;

ForegroundColor = ConsoleColor.DarkCyan;

Write("Enter your name: ");
var name = ReadLine();
WriteLine($"Hello {name}!");

ForegroundColor = ConsoleColor.Green;


WriteLine("\nUsing C# Library");
int num1 = 10, num2 = 20;

MathsCSSvc mathsCsSvc = new();
WriteLine($"{num1} + {num2} = {mathsCsSvc.AddNumbers(num1, num2)}");

WriteLine($"{num1} * {num2} = {mathsCsSvc.MultiplyNumbers(num1, num2)}");

WriteLine($"Max value is {MathsCSSvc.MaxValue}");

ForegroundColor = ConsoleColor.Yellow;

WriteLine("\nUsing VB.Net Library");
num1 = 10;
num2 = 20; /* Variable declaration and initialization. */

MathsVBSvc mathsVbSvc = new(); /* Instantiation of Maths class. */
WriteLine($"{num1} + {num2} = {mathsVbSvc.AddNumbers(num1, num2)}");

/* Accessing static members of a class. */
WriteLine($"{num1} * {num2} = {mathsVbSvc.MultiplyNumbers(num1, num2)}");

WriteLine($"Max value is {MathsVBSvc.MaxValue}");

ResetColor();

WriteLine("Press any key to exit.");
ReadKey();
