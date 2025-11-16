// Obtendo a Data Atual

DateTime DataAtual = DateTime.Now;

Console.WriteLine(DataAtual);


// Obtendo uma Data especifica (Sem horas)

DateTime DataEspecifica = new DateTime(2004, 10, 22);

Console.WriteLine(DataEspecifica);

// Data Especifica com Horas 

DateTime HorasEspecificas = new DateTime(2024, 10, 22, 15, 33, 33);

Console.WriteLine(HorasEspecificas);

Console.ReadLine();

// Extrair Informações da Data Atual

DateTime hoje = DateTime.Now;

Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

Console.ReadLine();

// Adiconando Valores a Datas 
Console.WriteLine(hoje.AddDays(30));;
Console.WriteLine(hoje.AddHours(10));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddYears(5));

Console.ReadLine();

// obtendo o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

