int[,] bidimensional = new int[2, 3] { {0, 1, 2}, {3, 4, 5 }};

for (int linha = 0; linha < bidimensional.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < bidimensional.GetLength(1); coluna++)
    {
        Console.WriteLine($"{bidimensional[linha, coluna]}");
    }
}

foreach (var x in bidimensional)
{
    Console.WriteLine(x);
}