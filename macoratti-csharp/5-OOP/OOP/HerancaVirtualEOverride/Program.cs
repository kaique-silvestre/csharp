public class Pessoa
{
    public string? Nome { get; set; }
    public virtual string Saudacao() => "Olá!";
}

public class Aluno : Pessoa
{
    public string? curso { get; set; }
    public override string Saudacao() => "Olá! Olá!";
}