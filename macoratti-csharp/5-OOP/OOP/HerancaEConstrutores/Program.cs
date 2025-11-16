/*
 O construtor da classe Aluno, chama primeiro o construtor da classe pessoa 
depois volta para o seu prórpio construtor.
*/

Aluno aluno = new("José");




public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor com parâmetro");
    }
}

public class Aluno : Pessoa
{
    public Aluno() : base() 
    {
        Console.WriteLine("Construtor da Classe Aluno");
    }
    public Aluno(string nome) : base(nome)
    {
        Console.WriteLine("Construtor com parâmetro");
    }
}