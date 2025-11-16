Console.WriteLine("Operador Ternário");

Console.Write("Informe a Temperatura: ");
var temperatura = Convert.ToDouble(Console.ReadLine());

var resultado = temperatura >= 27.00 ? "Está Quente" : "Está Normal";

Console.WriteLine($"A temperatura {resultado}");

