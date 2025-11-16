Console.WriteLine("Nullables Types");

Nullable<int> inteiro_nulo = null; // Suporta todos valores de int + null
Nullable<bool> bool_nulo = null;
Nullable<double> double_nulo = null;

Console.WriteLine(inteiro_nulo);
Console.WriteLine(bool_nulo);
Console.WriteLine(double_nulo);

// Simplificação da Declaração
/// Basta adicionar uma interrogação após o tipo de dado
int? simple_int = null;
float? simple_float = null;

Console.WriteLine(simple_int);
Console.WriteLine(simple_float);

Console.ReadLine();

// O nullable Type "int?" e diferente do tipo "int"
// É importante portanto converter um tipo para outro implicitamente 
// A conversão desses dados é feita com o seguinte operador: "??"

/*
    int a = null;
    int b = a; 
    - Essa é uma operação que não pode ser feita 

    -  A unica forma de fazer uma especie de converção é a seguinte sintaxe
    
    int? a = null;
    int b = a ?? 0;
    
    - Nesse caso o operador "??" irá avaliar se a variável a possui um valor nulo...
       se não  possuir um valor nulo o lado direito será atribuido a B (o proprio valor de a no caso)
    - Se for nulo lado de fora irá ser atribuido
 */

int? a = null;
int b = a ?? 0;
Console.WriteLine(b);

// Propriedades: HAsValue e Value
/// HasValue: true se tiver um valor false se for null
/// Value Exibe o valor atribuido

int? h = 100;
if (h.HasValue) 
{
    Console.WriteLine(h.Value);
}
else
{
    Console.WriteLine("Valor nulo");
};