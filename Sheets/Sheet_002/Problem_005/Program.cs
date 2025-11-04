using Problem_005.Services;
using Problem_005.Extensions;

var numberOfQueries = Convert.ToInt32(Console.ReadLine());

var leftEdges = new int[numberOfQueries];
var rightEdges = new int[numberOfQueries];
var middleValues = new int[numberOfQueries];

for (int i = 0; i < numberOfQueries; i++)
{
    leftEdges[i] = Convert.ToInt32(Console.ReadLine());
    rightEdges[i] = Convert.ToInt32(Console.ReadLine());
    middleValues[i] = Convert.ToInt32(Console.ReadLine());    
}

IRecursiveQueriesProblemSolver solver = new RecursiveQueriesProblemSolver();

var results = solver.Solve(numberOfQueries, leftEdges, rightEdges, middleValues);

results.Print();