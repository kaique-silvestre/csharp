
Console.WriteLine("Conversão Implita");
// A conversão implicita é possívelm se a fonte de dados original tiver um tamanho menor do que o novo tipo de dados, o inverso não é possível
// Exemplo:
int VarInt = 100;
double VarDouble = VarInt;

Console.WriteLine(VarDouble);

// byte - 1 byte
// short - 2 bytes 
// int - 4 bytes 
// float - 4 bytes 
// long - 8 bytes 
// double - 8 bytes 
// decimal - 16 bytes

// converções explicitas 
Console.WriteLine("Converções Explicitas");

int num1 = 10;
int num2 = 4;

float resultado = num1 / num2; // Mesma lógica já vista anteiormente apesar da variável ser um float o resultado é um int e é armazenado como tal

Console.WriteLine(resultado); // Resultado será um int 

Console.WriteLine("Precisa-se fazer um cast para forçar a conversão");

float resultado2 = (float) num1 / num2;

Console.WriteLine(resultado2); // Agora o resultado etsá preciso 


Console.ReadLine();