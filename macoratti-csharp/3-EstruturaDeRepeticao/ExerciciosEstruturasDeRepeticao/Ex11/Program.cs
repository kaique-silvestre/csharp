/*
 11 - Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e  quando isso ocorrer exibir uma mensagem de alerta)
*/

int num1, num2;
string operador;

Console.Write("Digite o Primeiro Número: \t");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o operador (+, -, x, /): \t");
operador = Console.ReadLine().ToLower(); 

Console.Write("Digite o Segundo Número: \t");
num2 = Convert.ToInt32(Console.ReadLine());

switch (operador)
{
    case "+":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"{num2} - {num2} = {num1 - num2}");
        break;
    case "*":
    case "x":
        Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
        break;
    case "/":
        if (num1 == 0 || num2 == 0)
        {
            Console.WriteLine("Não Existe Divisão por Zero. Operação Impossível");    
            break;
        } else
        {
            Console.WriteLine($"{num1} / {num2} = {(float) num1 / num2}");
        }
        break;
}