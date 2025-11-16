using Agregacao;


Professor prof1 = new Professor("Carlos", "Química");
Professor prof2 = new Professor("Maria", "inglês");
Professor prof3 = new Professor("Ana", "Literatura");
Professor prof4 = new Professor("Paulo", "Matemática");

Departamento dep1 = new Departamento("Exatas");
dep1.IncluirProfessor(prof1);
dep1.IncluirProfessor(prof4);
dep1.ListarProfessores();

Console.ReadKey();

Departamento dep2 = new Departamento("Humanas");
dep2.IncluirProfessor(prof2);
dep2.IncluirProfessor(prof3);
dep2.ListarProfessores();

Console.ReadKey();