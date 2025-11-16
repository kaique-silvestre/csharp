// Para criar uma instância da classe Demo precisamos usar o tipo da interface 

IControler d = new Demo();



interface IControler
{
    string Nome { get; set; }
    void Desenhar();
    public void Exibir()
    {
        Console.WriteLine("Exibindo");
    }
}

interface IGrafico
{
    void Pintar();
}

public class Demo : IControler, IGrafico
{
    public string Nome { get; set; } = string.Empty;
    public void Desenhar()
    {
        Console.WriteLine("Implementando Desenhar");
    }
    public void Pintar()
    {
        Console.WriteLine("Implementando Pintar");
    }
}