await OperacaaoAsync();

static async Task OperacaaoAsync()
{
    // Cria um CancellationResource 
    int tempo = 30;
    var CancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando o Download");
    Console.WriteLine($"\nCancelando a Operação em {tempo} Segundos");

    try
    {
        using var httpClient = new HttpClient();
        var destino = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\11-ProgramacaoAssincrona\dados\poesia.txt";

        var response = await httpClient.GetAsync("https://www.macoratti.net/dados/Poesia.txt", HttpCompletionOption.ResponseHeadersRead, CancellationTokenSource.Token);

        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fs = new FileStream(destino, FileMode.Create, FileAccess.ReadWrite);
        await using var contentStream = await response.Content.ReadAsStreamAsync(CancellationTokenSource.Token);

        var buffer = new byte[81920];
        int bytesRead;

        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, CancellationTokenSource.Token)) > 0)
        {
           await fs.WriteAsync(buffer, 0, bytesRead, CancellationTokenSource.Token);
            readBytes += bytesRead;
            Console.WriteLine($"Progeresso: {readBytes}/{totalBytes}");
        }
    }
    catch (OperationCanceledException ex)
    {
        if (CancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado por tempo limite");
        }
        else
        {
            Console.WriteLine("O tempo limite foi atingido");
        }
    }
    catch (HttpRequestException)
    {
        Console.WriteLine("Ocorreu um erro de rede");

    }
    catch (Exception)
    {
        Console.WriteLine("Ocorreu um erro desconhecido");
    }
    finally
    {
        Console.WriteLine("Operação Finalizada");
    }
}