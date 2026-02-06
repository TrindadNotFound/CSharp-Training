namespace S15_Delegate.Service;

public class CalculationService
{
    public static double Max(double x, double y)
    {
        return (x > y) ? x : y;
    }

    public static double Sum(double x, double y)
    {
        return x + y;
    }
    
    public static double Square(double x)
    {
        return x * x;
    }

    public static void ShowMax(double a, double b)
    {
        double max = Max(a, b);
        Console.WriteLine($"Max: {max}");
    }
    
    public static void ShowSum(double a, double b)
    {
        double sum = Sum(a, b);
        Console.WriteLine($"Sum: {sum}");
    }
}