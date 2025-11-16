/*
14- Escreva um programa que solicite a temperatura em graus Celsius e converta para Kelvin e Farhenheit usando as fórmulas a seguir:
- Converter para Kelvin => K = C + 273 ;
- Converter para Farhenheit => F = (C * 9) / 5 + 32 ; 
*/

Console.Write("Digite a temperatura em Cº: ");
double celcius = Convert.ToDouble(Console.ReadLine());

double kelvin = celcius + 273;
double farhenheit = (celcius * 9) / 5 + 32;
Console.WriteLine($"A tempertura em Kelvin: {kelvin}");
Console.WriteLine($"A temperatura em farhenheit: {farhenheit}");