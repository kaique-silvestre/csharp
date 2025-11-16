
Aluno aluno = new();

Console.WriteLine("Nome:");
aluno.nome = Console.ReadLine();

Console.WriteLine("Idade:");
aluno.idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sexo:");
aluno.sexo = Console.ReadLine();

Console.WriteLine("Aprovação:");
aluno.aprovado = Convert.ToBoolean(Console.ReadLine());

Curso curso = new();

curso.status(aluno.nome, aluno.idade, aluno.sexo, aluno.aprovado);

public class Aluno
{
    public string? nome;
    public int idade;
    public string? sexo;
    public bool aprovado;
}
public class Curso
{
    public void status(string? nome, int idade, string? sexo, bool aprovado)
    {
        Console.WriteLine($"Aluno de nome: {nome}, com {idade} anos, do sexo: {sexo}");
        if (aprovado)
            Console.WriteLine("Foi aprovado");
        else
            Console.WriteLine("Foi reprovado");
    }
}