using UseMathCSService.Services;

ForegroundColor = ConsoleColor.Green;

WriteLine("Hello .NET 8 World!"); 

WriteLine("Enter your name: ");
var name = ReadLine();
WriteLine($"Hello {name}!");

int num1 = 10, num2 = 20; 
MathsSvc maths = new(); 
WriteLine($"{num1} + {num2} = {maths.AddNumbers(num1, num2)}");

ResetColor();

WriteLine("Press any key to exit.");
ReadKey();
