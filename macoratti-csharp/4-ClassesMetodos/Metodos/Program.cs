// No top level domain a criação de classes vem sempre ao final de todas as intruções 


Saudacao MinhaSaudacao = new();
MinhaSaudacao.SaudacaoAtual();


class Saudacao
{
    public void SaudacaoAtual()
    {
        Console.WriteLine("Bem-Vindo, Você está em: ");
        Console.WriteLine(DateTime.Now);
    }
}