/*
 Crie um swtich que informe quais meses tem: 30 dias, 31 dias e fevereiro
 */


Console.Write("Qual mês você deseja saber a quantidade de dias: ");
string mes = Console.ReadLine().ToLower();


string resposta;


switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        resposta = "Esse mês tem 31 dias";
        break;
    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        resposta = "Esse mês tem 30 dias";
        break;
    case "fevereiro":
        resposta = "Esse mês tem 28 dias";
        break;
}

Console.WriteLine(resposta);
