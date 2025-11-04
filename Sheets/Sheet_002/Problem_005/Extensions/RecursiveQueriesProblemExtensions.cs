namespace Problem_005.Extensions;

public static class RecursiveQueriesProblemExtensions
{
    public static void Print(this IEnumerable<int> results)
    {
        Console.WriteLine("===============================");

        foreach (var item in results)
            Console.WriteLine(item);

        Console.WriteLine("===============================");
    }
}