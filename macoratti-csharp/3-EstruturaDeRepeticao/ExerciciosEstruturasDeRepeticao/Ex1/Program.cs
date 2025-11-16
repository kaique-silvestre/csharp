/*
1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior 
*/

int i, num;
int MaiorValor = 0;
Console.WriteLine("Escreva três números inteiros");

for (i = 0; i < 3; i++)
{
    Console.Write("Escreva um Número: \t");
    num = Convert.ToInt32(Console.ReadLine());

    if (i == 0)
    {
        MaiorValor = num;
    }
    else if (num > MaiorValor)
    {
        MaiorValor = num;
    }
}

Console.WriteLine($"O maior número é: {MaiorValor}");