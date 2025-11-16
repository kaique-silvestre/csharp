ClasseDerivada cd = new ClasseDerivada();

cd.VerificadorDeAcesso();


Console.ReadKey();

public class ClasseBase
{
    public void Public_Member()
    {
        Console.WriteLine("ClasseBase = Método Public");
    }

    protected void Protected_Member()
    {
        Console.WriteLine("ClasseBase = Método Protected");
    }
    internal void Internal_Member()
    {
        Console.WriteLine("ClasseBase = Método Internal");
    }

    protected internal void ProtectedInternal_Member()
    {
        Console.WriteLine("ClasseBase = Método Protected Internal");
    }
    private void Private_Member()
    {
        Console.WriteLine("ClasseBase = Método Private");
    }
}

public class ClasseDerivada : ClasseBase 
{
    public void VerificadorDeAcesso()
    {
        this.Public_Member(); // Acesso permitido   
        this.Protected_Member(); // Acesso permitido
        this.Internal_Member(); // Acesso permitido, pois está no mesmo assembly
        this.ProtectedInternal_Member(); // Acesso permitido, pois está no mesmo assembly
        // this.Private_Member(); // Acesso não permitido, pois é privado e não acessível na classe derivada
    }
}