public class Pessoa
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }
    public static int IdadeMinima;

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("Executando construtor publico com parâmetros");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa()
    {

    }

    static Pessoa()
    {
        Console.WriteLine("Executando o construtor estático");
        IdadeMinima = 18;
    }
}