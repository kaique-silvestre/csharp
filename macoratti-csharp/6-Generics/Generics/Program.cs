int i1 = 10;
int i2 = 10;

float f1 = 10;
float f2 = 10;

string s1 = "10";
string s2 = "10";

var t = new Teste();

/*
 * Dessa forma apenas podemos usar os tipos que são especificados nos parâmetros e devemos criar sobrecrcargas de métodos que irão suportar outros tipos
 
*/
t.ComparardorPadrao(i1, i2);

public class Teste
{
    public void ComparardorPadrao(int p1, int p2)
    {
        Console.WriteLine($" {p1} e {p2} sãi iguais? {p1.Equals(p2)}");
    }
    public void ComparardorPadrao(float p1, float p2)
    {
        Console.WriteLine($" {p1} e {p2} sãi iguais? {p1.Equals(p2)}");
    }
    public void ComparardorPadrao(string p1, string p2)
    {
        Console.WriteLine($" {p1} e {p2} sãi iguais? {p1.Equals(p2)}");
    }
}