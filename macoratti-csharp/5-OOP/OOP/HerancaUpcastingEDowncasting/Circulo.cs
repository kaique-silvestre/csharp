using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaUpcastingEDowncasting;

public class Circulo : Forma
{
    public Circulo() { }
    public Circulo(int x, int y) : base(x, y) { }

    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar círculo na posição: ({this.xpos},{this.ypos})");
    }
    public void PintarCirulo()
    {
        Console.WriteLine("Pintar Círculo");
    }

}
