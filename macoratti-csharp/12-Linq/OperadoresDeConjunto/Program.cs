

// Distinct
var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };

var IdadesDistintas = idades.Distinct(); // Execução tardia
var idadesDistintasImediatas = idades.Distinct().ToList(); // Execução Imediata

foreach ( var idade in IdadesDistintas)
    Console.WriteLine(idade);

Console.WriteLine("\n\n");

// O Distinct por sí só não é Case Senstive, ou seja não faz distinções de maiúscula ou minúscula, dessa forma precisamos usar uma das sobrecargas do método para fazer essa distinção

var VariosNomes = new[] { "Paulo", "MARIA", "paulo", "Amanda", "maria", "Amanda" };

// Todos os nomes dessa lista são diferentes caso estejamos considerando as diferneças no Cases das letras, para que isso não ocorra usamos a classe "StringComparer.OrdinalIgnorecase"

var VariosNomesDiferentes = VariosNomes.Distinct(StringComparer.OrdinalIgnoreCase);

Console.WriteLine(string.Join(" ", VariosNomesDiferentes));

Console.WriteLine("\n\n");

// Except

// Todos os elementos da fonte01 que não existem na fonte02
// Tudo o que está na primeira fonte e não está na segunda--

var fonte01 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9, 10};
var fonte02 = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18};

var resultado = fonte01.Except(fonte02);
Console.WriteLine(string.Join(" ", resultado));

// Intersect
// É usado para retornar os elementos de ambas as fontes de dados
// Os elementos iguais em ambas as fontes-- serão retornados 

var resultado2 = fonte01.Intersect(fonte02);
Console.WriteLine(string.Join(" ", resultado2));