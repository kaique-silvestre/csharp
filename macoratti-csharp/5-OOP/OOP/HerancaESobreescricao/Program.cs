Aluno aluno = new();
aluno.nome = "Leonardo";
aluno.curso = "Fisica";
Console.WriteLine(aluno.Saudacao());


public class Pessoa
{
    public string? nome { get; set; }
    public string Saudacao() => $"Oi, eu sou o(a) {nome}";
}

public class Aluno : Pessoa
{
    public string? curso { get; set; }
    public new string Saudacao() => $"Oi, eu sou o(a) {nome} e meu curso é {curso}";
}