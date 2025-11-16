
List<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

// Query Syntax

var resultado = from f in frutas
                where f.Contains('r')
                select f;

// Exibição do resultado da pesquisa
Console.WriteLine(string.Join(" ", resultado));


