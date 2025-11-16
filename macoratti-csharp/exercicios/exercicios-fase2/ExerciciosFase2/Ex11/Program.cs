/*
11 - Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
*/
;

Console.Write("Digite o Primeiro Número Inteiro: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o Segundo Número Inteiro: ");
int y = Convert.ToInt32(Console.ReadLine());


string resultadoX = x % 2 == 0 ? $"{x} é par" : $"{x} é impar";
string resultadoY = y % 2 == 0 ? $"{y} é par" : $"{y} é impar";
 
Console.WriteLine(resultadoX);
Console.WriteLine(resultadoY);