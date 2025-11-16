double[] variosnumeros = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };

double result1 = CalculosComArray.SomaVariavel(variosnumeros);
Console.WriteLine(result1);

double result2 = CalculosComArray.SomaVariavel(new double[] { 10, 10, 10 });
Console.WriteLine(result2);


var result3 = CalculosComArray.SomaVariavel(new int[] { 20, 20, 20 });
Console.WriteLine(result3);


public class CalculosComArray
{
    public static double SomaVariavel(double[] numeros) 
    {
        double total = 0.0;
        foreach (double num in numeros)
            total += num;
        return total;
    }

    public static int SomaVariavel(int[] numeros)
    {
        int total = 0;
        foreach (int num in numeros)
            total += num;
        return total;
    }
}