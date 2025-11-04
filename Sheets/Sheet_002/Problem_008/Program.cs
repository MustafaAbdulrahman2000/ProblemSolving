
using Problem_008.Services;

var input = Console.ReadLine();

ILongestPalindromicSubstringProblemSolver solver = new LongestPalindromicSubstringProblemSolver();

var longestPalindromicSubstring = solver.Solve(input!);

Console.WriteLine(longestPalindromicSubstring);