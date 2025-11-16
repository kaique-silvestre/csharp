namespace Ex4;

internal class Program
{
    public static void Main(string[] args)
    {
        Pessoa[] a = new Pessoa[4]
        {
            new Pessoa("douglas"),
            new Pessoa("Edson"),
            new Pessoa("Emerson"),
            new Pessoa("Marcos")
        };

        foreach (var p in a)
        {
            Console.WriteLine(p.ToString());
        }
    }
}
public class Pessoa
{
    // Construtor 
    public Pessoa(string nome)
    {
        this.Nome = nome;
    }
    // Propriedade 
    public string Nome { get; set; }

    public override string ToString()
    {
        return this.Nome;
    }
}
