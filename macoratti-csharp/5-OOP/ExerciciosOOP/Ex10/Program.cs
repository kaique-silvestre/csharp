namespace Ex10;
/*
 Exercício 10 
Usando os conceitos de polimorfismo escreva um programa para calcular a área do 
Quadrado, Triângulo e do Circulo
 Fórmulas das áreas
Quadrado -> A = lado * lado   --
 Triângulo ->   A = (base * altura)/2
 Circulo -> A =  Pi * raio * raio      
ou   A = π . r²
 
 
*/

using System;

internal class Program
{
    public static void Main(string[] args)
    {

    }
}

abstract public class Figura
{
    abstract public double CalcularArea();
}

public class Quadrado : Figura
{
    // Construtor 
    public Quadrado(double lado)
    {
        this.Lado = lado;
    }
    // Propriedade 
    public double Lado { get; set; }

    //Métodos
    public override double CalcularArea()
    {
        return this.Lado * this.Lado;
    }
}

public class Triangulo : Figura
{

    // Construtor 
    public Triangulo(double altura, double Base)
    {
        this.Altura = altura;
        this.Base = Base;
    }
    // propriedades 
    public double Altura { get; set; }
    public double Base { get; set; }

    // Métodos 
    public override double CalcularArea()
    {
        return (this.Base * this.Altura) / 2
    }
}

public class Circulo : Figura
{
    // Propriedades 
    public double Raio { get; set; }

    // Métodos
    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
}
