/*
 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for
*/

int soma = 0;

for(int i=1; i <= 10; i++)
{
    Console.WriteLine(i);
    soma += i;
}

Console.WriteLine($"Resultado com FOR: {soma}");

soma = 0;
int c = 0;

while(c <= 10)
{
    Console.WriteLine(c);
    soma += c;
    c++;
}

Console.WriteLine($"Resultado com WHILE: {soma}");

soma = 0;
c = 1;

do
{
    Console.WriteLine(c);
    soma += c;
    c++;
} while (c <= 10);

Console.WriteLine($"resultado com DO-WHILE: {soma}");

