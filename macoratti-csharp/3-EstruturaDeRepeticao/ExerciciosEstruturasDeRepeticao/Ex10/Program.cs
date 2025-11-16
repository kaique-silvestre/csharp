/*
10 - Crie um programa  que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a instrução switch, break e default em um loop infinito e defina uma condição de saida.) 
*/

// digite "Exit" Número negativo para sair do loop



while(true)
{
    Console.Write("Digite a nota do aluno: \t");
    string nota = Console.ReadLine().ToLower();

    if (nota == "exit")
    {
        break;
    }

    switch(nota)
    {
        case "10":
            Console.WriteLine("Nota: A+");
            break;
        case "9":
            Console.WriteLine("Nota: A");
            break;
        case "8":
        case "7":
            Console.WriteLine("Nota: B");
            break;
        case "6":
            Console.WriteLine("Nota: C");
            break;
        case "5":
            Console.WriteLine("nota: E");
            break;
        case "4":
        case "3":
        case "2":
        case "1":
        case "0":
            Console.WriteLine("Nota: F");
            break;
        default:
            Console.WriteLine("Valor não valido. Tente novamente ou digite \"exit\" para sair");
            break;
    }


}