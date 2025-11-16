/*
7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado:
*/


Console.Write("Primeiro Valor: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Segundo Valor: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1 + num2;
Console.WriteLine($"A soma é: {soma}");

double sub = num1 - num2;
Console.WriteLine($"A subtração é: {sub}");

double mult = num1 * num2;
Console.WriteLine($"A multiplicação é: {mult}");

double exp = Math.Pow(num1, num2);
Console.WriteLine($"A expondenciação é: {exp}");

double divisao = num1 / num2;
Console.WriteLine($"A divisão é: {divisao}");

double mod = num1 % num2;
Console.WriteLine($"o módulo é: {mod}");
