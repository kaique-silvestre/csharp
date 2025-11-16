/*
9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)
*/

Console.WriteLine("Login");
Console.Write("Usuário: ");
string user = Console.ReadLine();

Console.Write("Senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

string check = (user == "admin" || user == "maria") && senha == 123 ? "Login Válido" : "Login Inválido";

Console.WriteLine(check);