namespace Problem_003.Extensions;

public static class MonocarpStringProblemExtensions
{
    public static void Print(this IEnumerable<int> results)
    {
        Console.WriteLine("=====================================");

        foreach (var item in results)
            Console.WriteLine(item);

        Console.WriteLine("=====================================");
    }
}
