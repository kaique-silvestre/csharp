var frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

var resultado = frutas.Where(f => f.Contains('r'));

Console.WriteLine(string.Join(" ", resultado));

Console.WriteLine("\n");


var numeros = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

var re1 = numeros.Where(n => n < 10);
Console.WriteLine(string.Join(" ", re1));

var re2 = numeros.Where(n => n > 1 && n != 4 && n < 20);
Console.WriteLine(string.Join(" ", re2));