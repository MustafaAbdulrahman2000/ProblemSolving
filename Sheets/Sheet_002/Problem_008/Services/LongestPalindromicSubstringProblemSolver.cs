namespace Problem_008.Services;

public class LongestPalindromicSubstringProblemSolver : ILongestPalindromicSubstringProblemSolver
{
    private bool IsPalindromicString(string input)
        => input == new string(input.Reverse().ToArray());

    public string Solve(string input)
    {
        if (input.Length == 1 || IsPalindromicString(input))
            return input;

        var inputPrefix = Solve(input[1..]);
        var inputSuffix = Solve(input[..^1]);

        return inputPrefix.Length < inputSuffix.Length ?
               inputSuffix :
               inputPrefix;
    }
}
