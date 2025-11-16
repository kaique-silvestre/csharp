var pedido = new Pedido();

pedido.OnCriarPedido += Email.Send;
pedido.OnCriarPedido += SMS.Send;

pedido.CriarPedido();

// Criando o Delegate
public delegate void PedidoEventoHandler();





public class Pedido
{
    public event PedidoEventoHandler? OnCriarPedido;

    public void CriarPedido()
    {
        Console.WriteLine("Criando Pedido ! ! !");

        if (OnCriarPedido != null)
        {
            OnCriarPedido();
        }
    }
}

public class Email
{
    public static void Send()
    {
        Console.WriteLine("\nSending Email...");
    }
}

public class SMS
{
    public static void Send()
    {
        Console.WriteLine("\nSending SMS...");
    }
}
