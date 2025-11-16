Email email = new();

email.Enviar(assunto: "Urgente - Definição de Metas da Empresa", titulo: "Metas da Empresa", email: "teste@.email.com");



public class Email
{
    public void Enviar(string email, string titulo, string assunto)
    {
        Console.WriteLine($"Email: {email}, Titulo: {titulo}\nAssunto: {assunto}");
    }
}