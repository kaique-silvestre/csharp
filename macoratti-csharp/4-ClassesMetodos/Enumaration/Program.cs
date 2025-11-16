using Enumaration; 

// Exibindo o nome da constante 
Console.WriteLine("Exibindo o nome da constante");
Console.WriteLine(DiasDaSemana.Terca);
Console.WriteLine(DiasDaSemana.Quarta);

Console.ReadKey();

// Exibindo o valor 
Console.WriteLine("Exibindo o valor");
int dia01 = (int)DiasDaSemana.Segunda;
int dia07 = (int)DiasDaSemana.Domingo;
Console.WriteLine(dia01);
Console.WriteLine(dia07);

Console.ReadKey();

// Exibindo Ambos 
Console.WriteLine("Exibindo Ambos");
Console.WriteLine($"O dia {DiasDaSemana.Segunda} é o dia {dia01} da semana");
Console.WriteLine($"O dia {DiasDaSemana.Domingo} é o dia {dia07} da semana");

