// Fazendo um cast que irá falhar 

Object CarroObj = new Carro();

try
{
    var x = (string)CarroObj;

}
catch (Exception ex)
{
    Console.WriteLine("O casting ao falhar dispara uma exceção");
    Console.WriteLine(ex.Message);
}

var y = CarroObj as string;

if (y != null)
    Console.WriteLine("A conversão ocorreu");
else
    Console.WriteLine("Não foi possível converter");



class Carro { }