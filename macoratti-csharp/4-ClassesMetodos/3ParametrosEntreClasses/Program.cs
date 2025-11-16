Aluno aluno = new();
aluno.Consultar();
public class Aluno
{
    public string? nome;
    public int idade;
    public string? sexo;
    public bool? aprovado;

    public void Consultar()
    {
        Aluno aluno = new();

        Console.Write("Nome:\t");
        aluno.nome = Console.ReadLine();
        Console.Write("idade:\t");
        aluno.idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sexo:\t");
        aluno.sexo = Console.ReadLine();
        Console.Write("Aprovação:\t");
        aluno.aprovado = Convert.ToBoolean(Console.ReadLine());

        Curso curso = new();
        curso.exibir(aluno);

    }
}

public class Curso
{
    public void exibir(Aluno aluno)
    {
        Console.WriteLine($"{aluno.nome}, {aluno.idade}, {aluno.sexo}, {aluno.aprovado}");
    }
}