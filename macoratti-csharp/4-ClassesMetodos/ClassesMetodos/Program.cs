Console.WriteLine("Classes e Métodos");

Console.ReadKey();


Pessoa p1 = new Pessoa();
p1.Nome = "Kaique";
p1.Idade = 20;
p1.Sexo = "Masculino";

Console.WriteLine($"{p1.Nome}, {p1.Idade}, {p1.Sexo}");

Pessoa PessoaFeminina = new Pessoa();
PessoaFeminina.Nome = "Heloísa";
PessoaFeminina.Idade = 18;
PessoaFeminina.Sexo = "Feminino";

Console.WriteLine($"{PessoaFeminina.Nome}, {PessoaFeminina.Idade}, {PessoaFeminina.Sexo}");

class Pessoa
{
    // Atributos da Classe Pessoa
    public string? Nome;
    public int Idade;
    public string? Sexo;
    // Necessário colocar a palavra reservada "public" para que elas sejam acessiveis 
}

