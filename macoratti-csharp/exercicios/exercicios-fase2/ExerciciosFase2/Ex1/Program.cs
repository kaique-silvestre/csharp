/*
 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.
*/

string nome = "Paulo";
int idade = 17;
double nota = 7.5;


Console.WriteLine("Concatenação");

Console.WriteLine("Aluno " + nome + " tem " + idade + " e nota " + nota);

Console.WriteLine("interpolação");

Console.WriteLine($"O aluno {nome} tem {idade} e nota {nota}");