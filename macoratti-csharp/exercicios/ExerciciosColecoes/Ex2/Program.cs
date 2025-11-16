string[,] alunos; // declaração
alunos = new string[2, 5]; // Alocação


for (var linha = 0; linha < alunos.GetLength(0); linha++)
{
    for (var coluna = 0; coluna < alunos.GetLength(1); coluna++)
    {
        Console.Write($"Qual nome adicionar em: {linha}, {coluna}:\t");
        var nome = Console.ReadLine();
        alunos[linha, coluna] = nome;
    }
}

Console.WriteLine("Verificando array");

foreach (var x in alunos)
{
    Console.WriteLine(x);   
}