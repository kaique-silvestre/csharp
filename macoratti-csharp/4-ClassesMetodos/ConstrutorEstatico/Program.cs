Console.WriteLine("## Construtor Estático ##");
Console.ReadKey();

// inicialização do construtor parametrizado e do estático
Pessoa pessoa = new("Maria", 28);
Console.WriteLine($"{pessoa.Idade}, {pessoa.Nome}");
Console.WriteLine(Pessoa.IdadeMinima);


// Apenas o construtor parametrizado é inicializado
Pessoa pessoa2 = new("Manoel", 49);
Console.WriteLine($"{pessoa2.Nome}, {pessoa2.Idade}");
Console.WriteLine(Pessoa.IdadeMinima);
