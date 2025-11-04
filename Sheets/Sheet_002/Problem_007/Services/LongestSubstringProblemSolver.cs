namespace Problem_007.Services;

public class LongestSubstringProblemSolver : ILongestSubstringProblemSolver
{
    public int Solve(string input)
    {
        var distinctCharacters = input.Distinct().Count();
        var longestSubstring = "";
        var longestSubstringLength = 0;

        if (distinctCharacters == 1)
            return 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (longestSubstring.Length == distinctCharacters)
                return longestSubstring.Length;

            if (!longestSubstring.Contains(input[i]))
                longestSubstring += input[i];

            else if (longestSubstring.Contains(input[i]))
            {
                longestSubstringLength = (longestSubstringLength < longestSubstring.Length) ? longestSubstring.Length : longestSubstringLength;

                longestSubstring = input[i].ToString();
            }
        }

        return longestSubstringLength; // 3
    }
}
