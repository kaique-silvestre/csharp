Console.WriteLine("Programa de Divisão");
try
{
    Console.Write("Informe o 1° número: \t");
    int valor1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o 2° núemro: \t");
    int valor2 = Convert.ToInt32(Console.ReadLine());

    int final = valor1 / valor2;

    Console.WriteLine(final);
}
catch (Exception ex)
{
    Console.WriteLine("houve um erro");
    Console.WriteLine(ex.Message.ToString());
}
finally
{
    Console.WriteLine("Muito Obrigado por usar o programa");
}