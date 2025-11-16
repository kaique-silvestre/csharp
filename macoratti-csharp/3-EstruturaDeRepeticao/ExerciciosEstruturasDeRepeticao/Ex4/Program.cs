/*
 4 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado                                                                      
-- Verifique se o número é maior que zero e emita uma mensagem
-- Considere a tabela de multiplicação de 1 até 10
-- Após exibir a tabela torne a solicitar outro número 
-- Para sair do loop defina uma condição de saída 
- Dica: Use os loop while e for e para sair a instrução break
 */


int mult = -1;

while(mult != 0)
{
    Console.Write($"Digite um número inteiro positivo (0 para sair): \t");
    mult = Convert.ToInt32(Console.ReadLine());

    if (mult == 0)
    {
        break;
    }
    else if (mult < 0)
    {
        Console.WriteLine("Número Inválido");
    }
    else
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{mult} x {i} = {mult * i}");
        }
    }
}