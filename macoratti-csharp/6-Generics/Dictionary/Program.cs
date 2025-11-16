// Sintaxe de Criação
Dictionary<string, int> dict01 = new Dictionary<string, int>();

var dict02 = new Dictionary<string, int>();

// Criação de com capacidade 

var dict03 = new Dictionary<string, int>(5);

// Criação de um dicionário com atribuição de valor
var dict04 = new Dictionary<int, int>()
{
    {1, 2},
    {3, 4},
    {5, 6},
    {7, 8},
    {9, 10}
};

// Incluir elementos
dict04.Add(50, 100);
dict04.Add(200, 400);

var resultado = dict04.TryAdd(200, 1000);
Console.WriteLine(resultado);


// Exibindo Elementos 
foreach (var item in dict04)
{
    Console.WriteLine($"chave: {item.Key}, Valor: {item.Value}");
}