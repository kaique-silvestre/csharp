// Criando um ReadOnly a partir de outro objeto
using System.Collections.ObjectModel;

List<string> planetas = new() { "Terra", "Marte", "Saturno" };

var ReadOnlyPlanetas = new ReadOnlyCollection<string>(planetas);

// Criando um ReadOnly a partir do Método
var NovosPlanetas = planetas.AsReadOnly();

