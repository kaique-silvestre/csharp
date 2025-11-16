using HerancaModificadorAbstract;

Quadrado quad = new();
Console.WriteLine(quad.Descricao());

Console.WriteLine("informe a cor da Figura\t");
quad.Cor = Console.ReadLine();

Console.WriteLine("Informe o valor do lado do quadrado\t");
quad.Lado = Convert.ToInt32(Console.ReadLine());

quad.CalcularArea();
quad.CalcularPerimetro();

Console.WriteLine($"Área do quadrado: {quad.Area} m2");
Console.WriteLine($"Perimetro do Quadrado: {quad.Perimetro}");

Console.ReadKey();
