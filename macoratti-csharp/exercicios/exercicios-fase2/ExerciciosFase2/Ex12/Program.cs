/*
12 - Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)

-6 + x * 5
(13-2) * x
(x + -2) * (20 / x)
(12 + x) / (x - 4)
3 x^2 + x + 10
pi * x^2

*/

Console.Write("Digite um valor X inteiro: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Resultado da Primeira Operação: {-6 + x * 5}");

Console.WriteLine($"Resultado da Segunda Operação: {(13-2) * x}");

Console.WriteLine($"Resultado da Terceira Operação: {(x + -2) * (20 / x)}");

Console.WriteLine($"Resultado da Quarta Operação: {(12+x)/(x-4)}");

Console.WriteLine($"Resultado da Quinta Operação: {3 * Math.Pow(x, 2) + x + 10}");

Console.WriteLine($"Resultado da Sexta Operação: {Math.PI * Math.Pow(x, 2)}");
