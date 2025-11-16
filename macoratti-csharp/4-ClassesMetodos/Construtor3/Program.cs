Aluno aluno = new()

public class Aluno
{
    public Aluno(string nome) => Nome = nome;
    public Aluno(int idade, string sexo, bool aprovado):this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public bool? Aprovado;
}