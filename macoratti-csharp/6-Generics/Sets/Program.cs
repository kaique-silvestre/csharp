// Criação de HashSet com itens 
var numeros = new HashSet<int>() { 1, 2, 3, 4, 5 };

var frutas = new HashSet<string>() { "uva", "banana", "maça" };

HashSet<int> pares = new HashSet<int>();

for (int i = 0; i <= 10; i++)
{
    pares.Add(i * 2);
}


// Construtor usando IEnumerable

/// Usando List<>
var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
var conjunto = new HashSet<int>(lista1);

///Usando array[]
var array01 = new int[] { 1, 3, 5, 9, 10, 11};
var hashsetarray = new HashSet<int>(array01);