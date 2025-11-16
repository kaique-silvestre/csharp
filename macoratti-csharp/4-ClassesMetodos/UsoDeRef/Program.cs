int valor = 10;
Console.WriteLine(valor);
Operacoes.DobrarValor(ref valor);
Console.WriteLine(valor);


public class Operacoes
{
    public static void DobrarValor(ref int numero)
    {
        numero *= 2;
    }
}

//do Eu estava errado no retorno no método, já que o método recebe um parâmetro por referência, o retorno deve ser "void"
// Sempre que que um método com retorno especificado em sua assinatura não retorna nada, o erro "not all code paths return a value" riá ser aponta