Email email = new();

email.Enviar(email: "kaique.silvestre@fakemail.com", assunto: "Eu estou testando os parâmetros opcionais");


public class Email
{
    public void Enviar(string email="teste.@email.com", string titulo="reunião de Negócios", string  assunto="Discutir Metas")
    {
        Console.WriteLine($"Email: {email}, Tiutlo: {titulo}\nAssunto: {assunto}");
    }
}