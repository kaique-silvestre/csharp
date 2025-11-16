// Criação de uma Queue e adição de elementos
Queue<string> WeekDays = new Queue<string>();
WeekDays.Enqueue("Segunda");
WeekDays.Enqueue("Terça");
WeekDays.Enqueue("Quarta");
WeekDays.Enqueue("Quinta");
WeekDays.Enqueue("Sexta");


// Criando uma Queue a partir de um array
int[] pares = new int[5]
{
    2, 4, 6, 8, 10
};

var PilhaDePares = new Queue<int>(pares);

// Criando uma Queue a partir de uma Lista 
var ListaDeImpares = new List<int> { 1, 3, 5, 7, 9 };

Queue<int> PilhaDeImapares = new(ListaDeImpares);


// Exibição por meio do Foreach
foreach (var item in PilhaDeImapares)
{
    Console.WriteLine(item);
}

//Criação com definição de tamamho 
var tam = new Queue<int>(3);
tam.Enqueue(1);
tam.Enqueue(2);
tam.Enqueue(3);