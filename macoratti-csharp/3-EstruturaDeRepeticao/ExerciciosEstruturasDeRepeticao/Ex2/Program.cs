/*
2 - Escreva um programa para calcular a raiz da equação quadrática: ax² + bx + c = 0
- Considere a, b e c números inteiros (positivos, negativos e o zero)
- Para calcular as raízes use a fórmula de Báskara: x = -b +- sqtr(delta) / 2*a onde delta = b² - 4*a*c
*/


// ax² + bx + c = 0

// delta = b² - 4.a.c
// x = -b + Math.sqtr(delta)/2.a 


Console.WriteLine("ax² + bx + c");
Console.WriteLine("a:");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("b:");
double b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("c:");
double c = Convert.ToInt32(Console.ReadLine());

double delta = Math.Pow(b, 2) - (4*a*c);
double x1 = (-b + Math.Sqrt(delta))/2*a;
double x2 = (-b - Math.Sqrt(delta))/2*a;

Console.WriteLine($"delta: {delta}");
Console.WriteLine($"x1: {x1}");
Console.WriteLine($"x2: {x2}");

if(delta == 0)
{
    Console.WriteLine("As duas raizes são iguais");
}
else if (delta > 0)
{
    Console.WriteLine("Ambas as raízes são reais e diferentes");
}
else
{
    Console.WriteLine("As raizes são imaginarias; Sem solução real");
}