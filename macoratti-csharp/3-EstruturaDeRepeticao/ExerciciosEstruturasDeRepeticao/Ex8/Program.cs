/*
8 - Escreva um programa para calcular o fatorial de um número inteiro. O fatorial de um número é representado por : n! =>  n * (n – 1) * (n – 2) ....2*1. Exemplo : fatorial de 6 é representado por  6! = 6*5*4*3*2*1 
*/

int i;
int fatorial = 1;
int num = 5;

for(i = 2; i <= num; i++)
{
    fatorial *= i;
}
Console.WriteLine(fatorial);