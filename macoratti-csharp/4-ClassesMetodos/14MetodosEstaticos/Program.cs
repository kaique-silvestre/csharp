Console.WriteLine(Calculadora.Somar(10, 10));
Console.WriteLine(Calculadora.Subtrair(25, 50));
Console.WriteLine(Calculadora.Multiplicar(10, 10));
Console.WriteLine(Calculadora.Dividir(100, 10000));



public class Calculadora
{
    public static int Somar(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }
    public static double Dividir(double num1, double num2)
    {
        return num1 / num2;
    }
}