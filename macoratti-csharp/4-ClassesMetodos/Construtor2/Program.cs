/*
    - Quando existem dois construtores a diferenciação ao criar objetos se da justamemte na quantidade de parâmetros inicializados
    - Todos os parâmetros não inicializados teram o valor padrão atribuidos 
*/

Aluno aluno1 = new("Maria");
Aluno aluno2 = new(20, "Feminino", true);

public class Aluno
{
    public Aluno(string nome) => Nome = nome;

    public Aluno(int idade, string sexo, bool aprovado)
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