DelegateMulticast dl = MathOperations.Somar;
dl += MathOperations.Mult;
dl += MathOperations.Power;

dl(10, 10);

public class MathOperations
{
    public static void Somar(float x, float y) => Console.WriteLine(x + y);
    public static void Mult(float x, float y) => Console.WriteLine(x * y);
    public static void Power(float x, float y) => Console.WriteLine(Math.Pow(x, y));
}


public delegate void DelegateMulticast(float num1, float num2);