// Declrando Variáveis 
Console.WriteLine("Declrando Variáveis");
Console.WriteLine(); // Linha vazia
byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -2147483647;
uint valor4 = 2147483647;
long valor5 = -21474836489;

// CRTL + D - Copia a Linha 
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);

Console.ReadLine();
/*
--Declarando Variáveis na mesma linha
--- Desde que elas sejam do mesmo tipo 
 */

Console.WriteLine("Você pode declarar variáveis na mesma linha");
Console.WriteLine("Desde que elas sejam do mesmo tipo");
int var1 = 1, var2 = 2, var3 = 3;
Console.WriteLine(var1);
Console.WriteLine(var2);
Console.WriteLine(var3);
Console.ReadLine();

/*
-- Declarando constantes 
--- O seu valor não pode ser alterado durante a execução do programa 
 */

const int constante1 = 100;
const int constante2 = 1000;
Console.WriteLine("O valor de constantes não podem ser alterados durante a execução");
Console.WriteLine(constante1);
Console.WriteLine(constante2);
Console.ReadLine();