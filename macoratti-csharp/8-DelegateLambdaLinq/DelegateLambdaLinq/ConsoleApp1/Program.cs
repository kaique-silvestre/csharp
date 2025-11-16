Exibir print = Print;

print.Invoke("teste");
print("Teste");

static void Print(string text)
{
    Console.WriteLine(text);
}


public delegate void Exibir(string msg);