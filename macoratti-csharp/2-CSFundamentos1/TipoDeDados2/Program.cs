// Usando Valores double, Float e Decimal.
Console.WriteLine("Atribuindo valores double, float e decimal");

double n1 = 1.2345;
float n2 = 1.2345f;
decimal n3 = 1.2345m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadLine();

// Precisão em Relação a divisão dos tipos de ponto flutuante 
Console.WriteLine("Comparando precisão do float, double e decimal");
float x = 1f / 3f;
double y = 1d / 3d; // É necessário declarar os valores da divisão como double nesse caso, já que apenas haviamos declarado a variável que irá guardar esse valores como double.
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.ReadLine();