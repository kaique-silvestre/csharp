int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

Teste t = new();


/*
 * Usando o generics podemos fazer com que apenas um método possa ser usado para vários tipos diferentes
 
 */
t.ComparadorGenerico(i1, i2);
t.ComparadorGenerico(f1, f2);
t.ComparadorGenerico(s1, s2);


public class Teste
{
    public void ComparadorGenerico<T>(T p1, T p2)
    {
        Console.WriteLine($"{p1} e {p2} são iguais? {p1.Equals(p2)}");
    }
}