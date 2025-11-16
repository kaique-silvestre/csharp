/*
8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de  a b e c . Valores : a = 1 , b = 12 e c = -13
*/

double a = 1, b = 12, c = -13, delta;
double x1, x2; 

delta = Math.Pow(b, 2) - 4 * (a * c);

x1 = (-b + Math.Sqrt(delta)) / (2 * a);
x2 = (-b - Math.Sqrt(delta)) / (2 * a);

Console.WriteLine($"X1 = {x1}");
Console.WriteLine($"X2 = {x2}");
Console.WriteLine($"Delta = {delta}");