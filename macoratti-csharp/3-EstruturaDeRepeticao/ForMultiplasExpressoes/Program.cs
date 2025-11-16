// Multiplas instruções 
for(int i = 0, j = 0; i+j <= 100; i++, j++)
{
    Console.WriteLine($"{i} + {j} = {i+j}");
};

Console.ReadKey();

// Seções opcionais 

int k = 0;

for(; k <= 10;)
{
    Console.WriteLine($"Valor de k = {k}");
    k++;
}

