using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        await foreach(var item in GerarMeses())
        {
            Console.WriteLine(item);
        }

        
    }
    public static async IAsyncEnumerable<string> GerarMeses()
    {
        yield return "Janeiro";
        yield return "Fevereiro";
        await Task.Delay(3000);
        yield return "Março";
        yield return "Abril";


    }
}