using System.Collections;

// Declaração e instânciação 

// Primeiro Construtor 
ArrayList Lista01 = new ArrayList();
var Lista02 = new ArrayList();
ArrayList Lista03 = new();


// Segundo construtor 

ArrayList Lista04 = new ArrayList(5);
var Lista05 = new ArrayList(5);
ArrayList Lista06 = new(5);

//Adicionando elementos  

ArrayList Arr = new();

Arr.Add(10);
Arr.Add("string");
Arr.Add(5.25);
Arr.Add(true);
Arr.Add("");
Arr.Add(null);

// capacity funciona de 4 em 4

// inicializadores de objetos (object initializer)
// Cria um arraylist e faz a inicilização em uma única etapa

var List10 = new ArrayList()
{
    "Paulo", 4.5, 5, true, " ", null
};

var List11 = new ArrayList() { "string", 10, 1.5, true, " ", null };

var Lista12 = new ArrayList() { 0, 1, 2, 3, 4 };

// Método Insert
Lista12.Insert(1, 10);

// Adicionar coleção de elementos 
// AddRange(Icollection) - ao final do arraylist
// InsertRange(index, Icollection) - Adiciona arraylist em local especifico


int[] Array = { 10, 20, 30 };

var ArrayList = new ArrayList() { 1, 2, 3 };

ArrayList.InsertRange(1, Array);

// Remoção de Elementos 