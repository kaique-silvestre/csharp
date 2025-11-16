using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores;

public class Time
{
    string[] Times = new string[10];

    public string this[int i]
    {
        get 
        {
            if (i >= 0 && i < Times.Length)
                return Times[i];
            return "Erro";
        }
        set 
        {
            if ( i >= 0 && i < Times.Length)
                Times[i] = value;

        }
    }
}
