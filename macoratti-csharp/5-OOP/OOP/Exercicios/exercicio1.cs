using System;

using System;

/*
Crie um programa que implemente uma interface
IVeiculo com dois métodos, um para Dirigir
do tipo void e outro para Abastecer do tipo bool que possui um parâmetro do tipo int com a
quantidade de gasolina a abastecer.(defina isso como uma propriedade)
Em seguida, crie uma classe
Carro com um construtor que receba um parâmetro com a
quantidade inicial de gasolina do carro e implemente os métodos Dirigir e Abastecer do carro.
O método
Dirigir deve exibir na tela ” Dirigindo o carro.. carro..”, se a gasolina for maior que 0, caso
contrário deve exibir “ Sem gasolina... gasolina...”, e o método Abastecer deve aumentar a gasolina do
carro e retornar true
Para testar, crie um objeto do tipo
Carro com 0 de gasolina inicial e solicite ao usuário a
informação de uma quantidade de gasolina para abastecer via teclado e por fim execute o
método Dirigir do carro.

*/

class Program
{
    public static void Main(string[] args)
    {
        var c = new Carro(20);
        c.Dirigir();
        c.Dirigir();
        c.Dirigir();
        c.Dirigir();
        c.Dirigir();
        c.Abastecer(5);
        c.Dirigir();
    }
}
public interface IVeiuclo
{
    // Propriedade 
    public double GasolineAmount { get; set; }

    // Métodos 
    public void Dirigir();
    public bool Abastecer(double GasolineAmount);
}
public class Carro : IVeiuclo
{
    public Carro(double GasolineAmount)
    {
        this.GasolineAmount = GasolineAmount;
    }

    // Propriedades 
    public double GasolineAmount { get; set; }

    // Métodos
    public void Dirigir()
    {
        if (this.GasolineAmount > 0)
        {
            Console.WriteLine("Dirigindo o Carro...");
            this.GasolineAmount -= 5;
        }
        else
        {
            Console.WriteLine("Sem Gasolina...");
        }
    }
    public bool Abastecer(double GasolineAmount)
    {
        this.GasolineAmount = GasolineAmount;
        return true;
    }
}