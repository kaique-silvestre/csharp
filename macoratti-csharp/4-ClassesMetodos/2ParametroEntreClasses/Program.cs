Curso curso = new();
Aluno aluno = new();
curso.status(aluno);
public class Aluno
{
    public string? nome = "kaique";
    public int idade = 20;
    public string? sexo = "masc";
    public bool? aprovado = true;
}

public class Curso
{
    public void status(Aluno aluno)
    {
        Console.WriteLine($"{aluno.nome}, {aluno.idade}, {aluno.sexo}, {aluno.aprovado}");
    }
}