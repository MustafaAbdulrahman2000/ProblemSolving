using Problem_001.Models;

namespace Problem_001.Services;

public static class CandiesProblemSolver
{
    public const int Nephews = 3;
    public static int TestCases { get; set; }


    public static IEnumerable<MonocarpBag> Solve(IEnumerable<MonocarpBag> bags)
    {
        foreach (var bag in bags)
        {
            if (bag.ExistingCandies % Nephews == 0)
                bag.RemainingCandies = 0;

            else
                bag.RemainingCandies = (((bag.ExistingCandies / 3) + 1) * 3) - bag.ExistingCandies;
        }

        return bags;
    }  

    public static void Print(this IEnumerable<MonocarpBag> bags)
    {
        foreach (var bag in bags)
            Console.WriteLine(bag.RemainingCandies);
    }
}
