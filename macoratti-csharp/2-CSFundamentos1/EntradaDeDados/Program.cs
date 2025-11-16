// Entrada de Dados: Solicitando o nome do usuário

Console.Write("Digite o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"O seu nome é: {nome}\n");

Console.ReadKey();

// O método .ReadLine() sempre retorna uma string, portanto caso seja necessário a entrada de um número a conversão deve ser feita 
// Como no exemplo: 

Console.Write("Agora, digite a sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A sua idade é: {idade}");