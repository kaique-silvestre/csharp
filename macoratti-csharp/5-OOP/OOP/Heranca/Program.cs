var func = new Funcionario();
func.Nome = "João";
func.Idade = 30;
func.Email = "@example";
func.Empresa = "TechCorp";

func.Identificar();


Console.ReadKey();

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public int? Idade { get; set; }

    public void Identificar()
    {
        Console.WriteLine($"{this.Nome}, {this.Idade}, {this.Email}");
    }   
}

public class Funcionario : Pessoa
{
    public string? Empresa { get; set; }
    public decimal? Salario { get; set; }
}

public class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public double? Nota { get; set; }
}