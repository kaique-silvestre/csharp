using System.Text.Json;
using SerializacaoJSON;

string caminho = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\10-SerializacaoEDeserializacao\dados\ObjetoAluno.json";

Aluno aluno02 = new Aluno(20, "Marina", "marina@yahoo.com", 21);

using (var fs = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(fs, aluno02);
}