namespace Ex3;

internal class Program
{
    public static void Main(string[] args)
    {
        Aluno a = new("Eduardo");
        Professor p = new("Erique");

        a.Estudar();
        p.Explicar();
    }
}
public class Pesssoa
{

    // Construtor 
    public Pesssoa(string nome)
    {
        this.Nome = nome;
    }

    // Propriedade 
    public string Nome { get; set; }
}
public class Aluno : Pesssoa
{
    public Aluno(string nome) : base(nome) { }

    public void Estudar()
    {
        Console.WriteLine($"O(a) aluno(a): {this.Nome} está estudando");
    }
}
public class Professor : Pesssoa
{
    public Professor(string nome) : base(nome) { }

    public void Explicar()
    {
        Console.WriteLine($"O(a) professor(a): {this.Nome} está explicando");
    }
}