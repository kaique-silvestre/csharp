/*
 6 - Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:- Incrementando 2 em cada passo- Incrementando 1 em cada passo - Com e loop infinito (use "break" e "continue")
*/

// LOOP INFINITO NO CÓDIGO CUIDADO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   

for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
    {
        continue;
    }
    Console.WriteLine(i);
}

for(int k = 10;  k <= 20; k++)
{
    if (k % 2 == 0 && k != 16)
    {
        Console.WriteLine(k);
    }
}

int h = 10;

while (true)
{
    if (h == 16)
    {
        h += 2;
        continue;
    }
    if (h % 2 == 0)
    {
        Console.WriteLine(h);
    }
    h += 2;
    if (h > 20)
        break;
}

// LOOOOOOOP INFINITO !!!!!!!!!!!!!!!!!!!!!!!!!!
while (true)
{
    if(h % 2 == 0 && h != 16 && h <= 20)
    {
    Console.WriteLine(h);
    }
    h += 2;
    if (h > 20)
        h = 10;
}