internal class Program
{
    private static void Main(string[] args)
    {
       
    }

    private static Task<int> OperacaoLongaDuracao(int valor)
    {
        Console.WriteLine("Executou a operac");

        // Inicia  a Tarefa e retorna
        return Task.Run(() =>
        {
            int resultado = 0;
            for (int i = 0; i < valor; i++)
            {
                Thread.Sleep(50);
                resultado += i;
            }
            return resultado;
        });
    }
}