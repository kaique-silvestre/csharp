using System.Linq;

var names = new List<string>()
{
    "Homero", "Omar", "Marcos", "Maria", "Marina", "Matheus", "Martins"
};

var resultado = from m in names
                where m.Contains("M") || m.Contains("m")
                select m;

foreach (var item in resultado)
    Console.WriteLine(item);

// Sintaxe de Método

var names2 = new List<string>()
{
    "Kaique", "Kayak", "Katana", "kwiu", ""
};


var resultado2 = names2.Where(n => n.Contains("K"));
foreach (var item in resultado2)
    Console.WriteLine(item);