List<string> nomes = new List<string>() { "Paulo", "Tarcisio", "Amaral", "Pedro", "Debora", "Helena", "Percival", "Manoel", "Rute", "Jose"};


// OrderBy
var resultado = nomes.OrderBy(nome => nome);
Console.WriteLine(string.Join(" ", resultado));

Console.WriteLine();

//OrderByDesceding
var resultado2 = nomes.OrderByDescending(nome => nome);
Console.WriteLine(string.Join(" ", resultado2));
