/* 
 * Crie um programa console que usando a classe HttpClient acesse um arquivo na internet 
 * Verifique se o acesso foi feito com sucesso e lance a exceção HttpRequestException caso ocorra uma execução
 * Realize o tratamento de exceções considerando as excções relacionadas ao código de status (StatusCode) HTTP: 400, 401, 402 404, 500 usando filtro nas exceções
 * Url do servidor: https://macoratti.net/dados
 * Nome do arquivo: poesia.txt
 */

try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados");
    Console.Write("Informe o nome do arquivo: \t");
    string? arquivo = Console.ReadLine();
    Console.Write("\nInforme a url do site: \t");
    string? url = Console.ReadLine();

    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + arquivo).Result;

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("O acesso ao site foi um sucesso");
        Console.WriteLine("Status code" + response.StatusCode);
    }
    else
    {
        throw new HttpRequestException();
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição Inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro");
}