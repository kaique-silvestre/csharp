int result = ModificadorParams.SomaVariavel(10, 10, 10, 10, 10);
Console.WriteLine(result);

public class ModificadorParams
{
    public static int SomaVariavel(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
            total += num;
        return total;
    }
}