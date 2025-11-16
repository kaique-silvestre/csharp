/*
 * Crie um programa C# que recebe via teclado o nome de cinco alunos e armazene os nomes em um array chamado nomes, e, a seguir receba também via teclado a nota, como um double dos cinco alunos e armazene os valores em um array chamado notas 
 * 
 * A seguir realize as seguintes operações:
 *      - Acessar e exibir no console os nomes dos alunos armazenados no array nomes;
 *      - Acessar e exibir no console as notas dos alunos armazenaods no array nota
 *      - Calcular a média aritimética das notas e exibir no console o valor obtido

 
 
*/

string[] Nomes = new string[5];
double[] Notas = new double[5];

for ( int i = 0; i <= 4; i ++)
{
    Console.Write("Nome:\t");
    string? Nome = Console.ReadLine();
    Console.Write("Nota:\t");
    double Nota = Convert.ToDouble(Console.ReadLine());

    Nomes[i] = Nome;
    Notas[i] = Nota;
}


for ( int i = 0; i < Nomes.Length; i++)
{
    Console.WriteLine($"O Aluno {Nomes[i]}, tem a Nota: {Notas[i]} ");
}

double cont = 0;

foreach ( int num in Notas )
{
   cont += num;
}

double media = cont / Notas.Length;

Console.WriteLine($"A média da sala é {media}");