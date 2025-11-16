int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };

System.Console.WriteLine("Exibindo Array:");

int count = 0;
foreach (var item in numeros)
{
    System.Console.WriteLine($"{count} - {item}");
    count++;
}

try
{
    Console.Write("Informe o índice do array para acessar: \t");
    int? index = Convert.ToInt32(Console.ReadLine());
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("O número digitado está fora do index do array");
}
catch (ArgumentNullException)
{
    Console.WriteLine("Nenhum valor foi digitado");
}
catch (FormatException)
{
    Console.WriteLine("Valor deve ser um número");
}
