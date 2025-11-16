char option = 'z';

while (option != 'X')
{
    Console.WriteLine("Qual é a instrução correta para sair de um loop?");
    Console.WriteLine("A ) quit");
    Console.WriteLine("B ) continue");
    Console.WriteLine("C ) break");
    Console.WriteLine("D ) exit");
    Console.WriteLine("Qual é a opção correta? (\'X\' para sair)");
    option = Convert.ToChar(Console.ReadLine().ToUpper());
   if (option == 'A' || option == 'B' || option == 'D')
    {
        Console.WriteLine("RESPOSTA INCORRETA");
    }
   else if (option == 'C')
    {
        Console.WriteLine("RESPOSTA CORRETA");
    }
}
