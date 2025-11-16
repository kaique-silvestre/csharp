Console.WriteLine("Operador Ternário Aninhado");
Console.Write("Digite o valor de X: ");
var ValorX = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o Valor de Y: ");
var ValorY = Convert.ToInt32(Console.ReadLine());

var result = ValorX > ValorY ? "X é maior" : ValorX < ValorY ? "Y é maior" : ValorX == ValorY ? "Valores iguais" : "Sem resultado";

Console.WriteLine(result);