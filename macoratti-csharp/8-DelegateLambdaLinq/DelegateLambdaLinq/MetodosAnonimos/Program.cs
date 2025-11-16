PrintNum print = delegate (int num)
{
    Console.WriteLine($"Número: {num}");
};

print(50);

public delegate void PrintNum(int num);