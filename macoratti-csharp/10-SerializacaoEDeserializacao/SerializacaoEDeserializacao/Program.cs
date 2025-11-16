using SeriazalicaoXML;
using System.Xml.Serialization;

Aluno aluno01 = new Aluno(101, "Maria", "mary@yahoo.com", 21, "teste");

string caminho = @"C:\Users\kaiqu\Desktop\biblioteca\csharp\macoratti-csharp\10-SerializacaoEDeserializacao\dados\ObjetoAluno.xml";

// Criar um objeto XmlSerializer, que em seu construtor deve conter o tipo dos objetos que ele irá converter
var Serializer = new XmlSerializer(typeof(Aluno));

using (var sw = new StreamWriter(caminho))
{
    Serializer.Serialize(sw, aluno01);
}