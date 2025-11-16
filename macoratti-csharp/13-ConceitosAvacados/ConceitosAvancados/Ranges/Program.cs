
// 1. Substring com range (abordagem moderna)

using System.Globalization;

string texto = "HelloWorld";
string resultado = texto[..3];

Console.WriteLine(resultado);

// 2. Extrair range de array
int[] numeros = { 10, 20, 30, 40, 50 };
int[] DoisUltimos = numeros[^2..]; // Apenas 2 últimos elementos

foreach (var numero in DoisUltimos)
{
    Console.WriteLine(numero);
}

// Indices 

string[] frutas = { "Banana", "Maça", "Uva" };

string ultimo = frutas[^1];
string penultimo = frutas[^2];
string antepenultimo = frutas[^3];

Console.WriteLine(ultimo);
Console.WriteLine(penultimo);
Console.WriteLine(antepenultimo);

// Se não houver elementos no indice chamado, a exceção "IndexOutOFRange" será lançada. Igualmente será lançada uma exceção para referências nulas quando o array for nulo

Console.WriteLine();

// Ranges

int[] NumbersArray = { 1, 2, 3, 4, 5 };

int[] TodosNumeros = NumbersArray[..]; // {1, 2, 3, 4, 5}

Exibir(TodosNumeros);
Console.WriteLine();

int[] UltimosTres = NumbersArray[2..]; // {3, 4, 5}

Exibir(UltimosTres);

Console.WriteLine();

int[] NaoUltimo = NumbersArray[..4]; // {1, 2, 3, 4}

Exibir(NaoUltimo);

Console.WriteLine();

int[] flow = NumbersArray[1..4];

Exibir(flow);

static void Exibir(int[] arrnums)
{
    foreach (var item in arrnums)
    {
        Console.WriteLine(item);
    }
}

// Se não sabemos o tamanho de um array, podemos pegar também seu penultimo membro da seguinte forma:
Console.WriteLine();

int[] NaoSeiOFinal =  NumbersArray[..^1]; // {1, 2, 3, 4}
Exibir(NaoSeiOFinal);