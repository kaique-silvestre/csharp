static async Task<string> BuscaUsuarioAsync(int id)
{
    await Task.Delay(2000);
    return $"Usário de ID: {id} encontrado.";
}
