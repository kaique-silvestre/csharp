/*
3 - Escreva um program onde o usuário é solicitado a informar um valor via teclado e armazenar o valor na variável entrada do tipo string onde tem que verificar 3 condições diferentes:

A - Se a entrada é nula, uma exceção ArgumentNullException é lançada com a mensagem "A entrada não pode ser nula." (Verifique a diferença entre ArgumentException e ArgumentNullException)

B - Se a entrada está vazia, uma exceção ArgumentException é lançada com a mensagem "A entrada não pode estar vazia."

C - Se a entrada passar nas verificações anteriores, a entrada é exibida na tela.
Realize o tratamento de erro para essas condições usando o bloco try-cath-finally
 
 */

try
{
    Console.WriteLine("Informe um valor: \t");
    string? value = Console.ReadLine();

    if (string.IsNullOrEmpty(value))
    {
        throw new NullReferenceException();
    }
    else if (value.Length == 0)
    {
        throw new NullReferenceException();
    }
}
catch (ArgumentException)
{
    Console.WriteLine("A entrada não pode estar vazia.");
}
catch (NullReferenceException)
{
    Console.WriteLine("A entrada não pode ser nula.");
}
finally
{
    Console.WriteLine("A Entrada passou nas duas verificações");
}

