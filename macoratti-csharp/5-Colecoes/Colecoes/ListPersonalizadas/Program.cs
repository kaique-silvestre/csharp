List<Produto> ListaProdutos = new List<Produto>();

ListaProdutos.Add(new Produto("Computador", 3500));
ListaProdutos.Add(new Produto("Celular", 2000));
ListaProdutos.Add(new Produto("TV", 5000));


foreach (var item in ListaProdutos)
{
    Console.WriteLine(item);
}




public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {this.Nome}, {this.Preco}.");
    }
}