namespace Problem_014.Extensions;

public static class ProblemExtensions
{
    public static int FindMinimum(int [] array)
    {
        if (array.Min() == 0)
            return 1;
        else
            return array.Min();
    }

    public static int FindMaximum(int [] array)
    {
        if (array.Max() == 0)
            return 1;
        else
            return array.Max();
    }
}
