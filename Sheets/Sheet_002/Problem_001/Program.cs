using Problem_001.Models;
using Problem_001.Services;

CandiesProblemSolver.TestCases = Convert.ToInt32(Console.ReadLine());

List<MonocarpBag> bags = new List<MonocarpBag>();

for (int i = 0; i < CandiesProblemSolver.TestCases; i++)
{
    var temp = new MonocarpBag 
    { 
        ExistingCandies =  Convert.ToInt32(Console.ReadLine())
    };

    bags.Add(temp);
}

var results = CandiesProblemSolver.Solve(bags);

results.Print();

