List<Aluno> ListaAlunos = new List<Aluno>()
{
    new Aluno("Maria", 8.75),
    new Aluno("Manoel", 6.75),
    new Aluno("Amanda", 7.25),
    new Aluno("Carlos", 6.55),
    new Aluno("Jaime", 8.50),
    new("Debora", 5.95),
    new("Alicia", 9.25),
    new("Sandra", 5.55),
    new("Marta", 7.85),
    new("Sueli", 9.15)
};

ListaAlunos.Add(new Aluno("Bia", 7.75));
ListaAlunos.Add(new("Mario", 8.95));

var obj = new AlunoOperation();

obj.ExibirDados(ListaAlunos);

Console.ReadKey();

var Amanda = ListaAlunos.FindIndex(x => x.Nome == "Amanda");

ListaAlunos.Remove(ListaAlunos[Amanda]);

obj.ExibirDados(ListaAlunos);

Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Alunos com nota maior que 8");

foreach(var item in ListaAlunos)
{
    if(item.Nota > 8)
        Console.WriteLine($"{item.Nome}, {item.Nota}");
}

public class Aluno 
{
    // Props 
    public string Nome { get; set; }
    public double Nota { get; set; }

    //Constructor 
    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

}

public class AlunoOperation
{
    public void ExibirDados(List<Aluno> Lista)
    {
        double sum = 0;
        double media;
        foreach(var item in Lista)
        {
            Console.WriteLine($"Aluno: {item.Nome}, {item.Nota}");
            sum += item.Nota;
        }
        media = sum / (double)Lista.Count;
        Console.WriteLine($"Média da Turma: {media}. Quantidade de alunos na turma: {Lista.Count}");
    }
}