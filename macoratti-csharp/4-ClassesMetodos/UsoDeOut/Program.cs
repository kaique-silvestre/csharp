int resultado;

Area.CalcularArea(10, 10, out resultado);
Console.WriteLine(resultado);


public class Area
{
    public static void CalcularArea(int largura, int altura, out int area)
    {
        area = largura * altura;
    }
}


// O out é usado quando o parâmetro é declarado mas, não inicializado, porém lhe precisa ser atribuido um valor durante o processamneto dos dados dentro do método.