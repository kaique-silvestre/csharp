using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace HerancaUpcastingEDowncasting;

public class Forma
{
    protected int xpos, ypos;
    public Forma() { }
    public Forma(int x, int y) // Construtor parametrizado
    {
        xpos = x;
        ypos = y;
    }
    public virtual void Desenhar()
    {
        Console.WriteLine($"Desenhar - Forma na posição: ({this.xpos},{this.ypos})");
    }
}
