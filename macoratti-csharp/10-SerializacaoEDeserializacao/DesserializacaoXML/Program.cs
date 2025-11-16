using System.Linq.Expressions;
using System.Xml.Serialization;
using SeriazalicaoXML;

string caminho = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\10-SerializacaoEDeserializacao\dados\ObjetoAluno.xml";


var serialization = new XmlSerializer(typeof(Aluno));

using (var sr = new StreamReader(caminho))
{
    var objeto = (Aluno)serialization.Deserialize(sr);

    Console.WriteLine($"{objeto.Id}, {objeto.Name}, {objeto.Idade}, {objeto.Email}");
}