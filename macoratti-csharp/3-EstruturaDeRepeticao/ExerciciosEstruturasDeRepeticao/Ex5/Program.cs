/*
  5 - Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder. Não utilize a instrução break.
*/

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
    switch (option)
    {
        case 'A':
        case 'B':
        case 'D':
            Console.WriteLine("RESPOSTA ERRADA");
            break;
        case 'C':
            Console.WriteLine("RESPOSTA CORRETA");
            break;
        case 'X':
            Console.WriteLine("SAINDO...");
            break;
        default:
            Console.WriteLine("OPÇÃO INVÁLIDA");
            break;
    }
}