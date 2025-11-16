/*
 9 - Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado 
*/

int num = 2;
int mult = 1;

do
{
    Console.WriteLine($"{num} x {mult} = {num * mult}");
    mult++;
    if (mult == 11)
    {
        Console.WriteLine();
        num++;
        mult = 1;
    }

} while (num <= 6 && mult <= 10);