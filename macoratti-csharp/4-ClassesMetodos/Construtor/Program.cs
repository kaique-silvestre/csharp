// Não é mais possível instânciar uma classe sem inicializar os parâmetros, não pode haver objetos vazios 
Aluno aluno1 = new("Kaique", 20, "Masculino", true);


public class Aluno
{
    public Aluno(string nome, int idade, string sexo, bool aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public bool? Aprovado;
}