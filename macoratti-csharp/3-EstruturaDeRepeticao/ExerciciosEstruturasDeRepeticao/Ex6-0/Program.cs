/*
 7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*).  
Ex:
     *
     **
     ***
     ****     
(dica : loop aninhado) 
*/

string ast = "*";
for(int i = 1; i <= 4; i++)
{
    Console.WriteLine(ast);
    ast += "*";
}