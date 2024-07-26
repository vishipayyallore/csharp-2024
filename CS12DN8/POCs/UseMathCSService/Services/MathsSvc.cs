namespace UseMathCSService.Services;

public class MathsSvc
{
    public const int MaxValue = 100;

    public int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public int MultiplyNumbers(int a, int b) => a * b;
}