using UseMathCSService.Services;

ForegroundColor = ConsoleColor.Green;

WriteLine("Hello .NET 8 World!");

Write("Enter your name: ");
var name = ReadLine();
WriteLine($"Hello {name}!");

MathsSvc maths = new();

int num1 = 10, num2 = 20;
WriteLine($"\n{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

WriteLine($"{num1} * {num2} = {maths.MultiplyNumbers(num1, num2)}");

WriteLine($"Max value is {MathsSvc.MaxValue}");

ResetColor();

WriteLine("Press any key to exit.");
ReadKey();
