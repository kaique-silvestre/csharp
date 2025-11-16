// Criação de uma stack e adição de elementos
Stack<string> WeekDays = new Stack<string>();
WeekDays.Push("Segunda");
WeekDays.Push("Terça");
WeekDays.Push("Quarta");
WeekDays.Push("Quinta");
WeekDays.Push("Sexta");


// Criando uma Stack a partir de um array
int[] pares = new int[5]
{
    2, 4, 6, 8, 10
};

var PilhaDePares = new Stack<int>(pares);

// Criando uma Stack a partir de uma Lista 
var ListaDeImpares = new List<int> { 1, 3, 5, 7, 9  };

var PilhaDeImapares = new Stack<int>(ListaDeImpares);


// Exibição por meio do Foreach
foreach (var item in PilhaDeImapares)
{
    Console.WriteLine(item);
}