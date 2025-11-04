using Problem_003.Extensions;
using Problem_003.Services;

var testCases = Convert.ToInt32(Console.ReadLine());

IMonocarpStringProblemSolver solver = new MonocarpStringProblemSolver();

var results = new List<int>();

for (int i = 0; i < testCases; i++)
{
    var numberOfLetters = Convert.ToInt32(Console.ReadLine());

    var text = Console.ReadLine();

    results.Add(solver.Solve(text!.ToArray()));
}

results.Print();