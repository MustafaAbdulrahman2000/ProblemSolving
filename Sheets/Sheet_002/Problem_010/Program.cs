using Problem_010.Services;

var input = Console.ReadLine();

IAtoiProblemSolver solver = new AtoiProblemSolver();

Console.WriteLine(solver.Solve(input!));