List<string> Frutas = new List<string>()
{
    "Uva", "Banana", "Laranja"
};

var fruta = Frutas.Find(y => y.Contains('n'));
Console.WriteLine(fruta);