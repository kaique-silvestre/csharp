
const string caminho = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\9-Arquivos\ArquivosDeTexto\Arquivo01.txt";

// Criar Arquivo
//File.Create(caminho);

//Escrever em um arquivo
/// Cria o arquivo se ele não existir
/// Não escreve em arquivo aberto
//File.WriteAllText(caminho, "Linha um \r\n Linha dois");

// Adicionando novo texto (append)
File.AppendAllText(caminho, "\nNovo Texto");


// Lendo todo o conteúdo
var texto = File.ReadAllText(caminho);

Console.WriteLine(texto + "\n");


// Lendo linha por linha
var linhas = File.ReadLines(caminho);
foreach (var linha in linhas)
    Console.WriteLine(linha);