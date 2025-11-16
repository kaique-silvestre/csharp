Console.WriteLine("Conversão para .ToString()");

int ValorInt = 123;
double ValorDouble = 12.45;
decimal ValorDecimal = 12.45678m;

string s1 = ValorInt.ToString();
string s2 = ValorDouble.ToString();
string s3 = ValorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);