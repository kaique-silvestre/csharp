using SerializacaoJSON;
using System.Text.Json;

string caminho = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\10-SerializacaoEDeserializacao\dados\ObjetoAluno.json";

// Lê todo conteúdo do arquivo JSON
string JsonContent = File.ReadAllText(caminho);

//Desserialia o objeto do arquivo JSoN e retorna 
var aluno = JsonSerializer.Deserialize<Aluno>(JsonContent);

Console.WriteLine($"{aluno.Id}, {aluno.Name}, {aluno.Email}");