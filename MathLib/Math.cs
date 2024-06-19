namespace MathLib;

public static class Math
{
    public static int Add(int x, int y)
        { return x + y; }
    public static int Subtract(int x, int y) 
        { return x - y; }
    public static int Multiply(int x, int y) 
        { return x * y; }
    public static int Divide(int x, int y)
        { return x / y; }
    public static int Mod(int x, int y)
        { return x - (x / y * y); }
    public static int Squared(int x)
        { return x * x; }
    public static int Fact(int x)
    {
        var sum = 1;
        for (int i = x; i > 1; i--)
        {
            sum *= i;
        }
        return sum;
    }
}            
