using Problem_009.Services;

var number = Convert.ToInt32(Console.ReadLine());

IReverseIntegerProblemSolver solver = new ReverseIntegerProblemSolver();

Console.WriteLine(solver.Solve(number));