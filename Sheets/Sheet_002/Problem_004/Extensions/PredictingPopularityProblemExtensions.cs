namespace Problem_004.Extensions;

public static class PredictingPopularityProblemExtensions
{
    public static void Print(this IEnumerable<int> results)
    {
        Console.WriteLine("===================================");

        foreach (var item in results)
            Console.WriteLine(item);

        Console.WriteLine("===================================");
    }

}
