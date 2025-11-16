using HerancaUpcastingEDowncasting;
// Upcasting 

// 1° Forma de fazer Upcasting
// Definir uma variável de tipo superiror e atribuir uma de tipo inferior
// Atribuimos a Forma (Classe Base) Circulo (Classe Derivada)
Forma Circulo = new Circulo(10, 20);
Circulo.Desenhar(); // Acesso aos métodos de forma 


//2° Forma de fazer Upcasting 
// Cria-se uma var de um tipo derivado e depois atribuí essa var a uma nova var de tipo base 
Circulo Circulo02 = new(10, 20);

Forma forma01 = Circulo02;

// Downcasting 
Forma forma02 = new(10, 20);
Circulo c = (Circulo)forma02; // -> downcasting explícito


