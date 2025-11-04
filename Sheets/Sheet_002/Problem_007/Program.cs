using Problem_007.Services;

var input = Console.ReadLine();

ILongestSubstringProblemSolver solver = new LongestSubstringProblemSolver();

Console.WriteLine(solver.Solve(input!));