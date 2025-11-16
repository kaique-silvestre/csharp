/*
5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
*/

Console.Write("Escreva uma letra: ");
string char1 = Console.ReadLine();
Console.Write("Escreva a segunda letra: ");
string char2 = Console.ReadLine();
Console.Write("Escreva a terceira letra: ");
string char3  = Console.ReadLine();

Console.WriteLine($"Exibindo na ordem inversa a digitada: {char3}, {char2}, {char1}");