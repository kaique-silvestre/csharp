/*
13- Considere o seguinte trecho de código:
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y)
*/

int y = 5;
y = (y++) + y + (++y);
Console.WriteLine(y);
y = y++ + y + ++y;
Console.WriteLine(y);