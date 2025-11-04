using Problem_004.Extensions;
using Problem_004.Services;

var actionRating = Convert.ToInt32(Console.ReadLine());
var dramaRating = Convert.ToInt32(Console.ReadLine());

var numberOfUsers = Convert.ToInt32(Console.ReadLine());
var usersActionPreferences = new int[numberOfUsers];
var usersDramaPreferences = new int[numberOfUsers];

for (int i = 0; i < numberOfUsers; i++)
    usersActionPreferences[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberOfUsers; i++)
    usersDramaPreferences[i] = Convert.ToInt32(Console.ReadLine());

var numberOfChangingRequests = Convert.ToInt32(Console.ReadLine());
var numberOfChangingUsers = new int[numberOfChangingRequests];
var newActionPreferences = new int[numberOfChangingRequests];
var newDramaPreferences = new int[numberOfChangingRequests];

for (int i = 0; i < numberOfChangingRequests; i++)
{
    numberOfChangingUsers[i] = Convert.ToInt32(Console.ReadLine());
    newActionPreferences[i] = Convert.ToInt32(Console.ReadLine());
    newDramaPreferences[i] = Convert.ToInt32(Console.ReadLine());
}

IPredictingPopularityProblemSolver solver = new PredictingPopularityProblemSolver();

var movieWatchers = solver.Solve(
    actionRating,
    dramaRating,
    numberOfUsers,
    usersActionPreferences,
    usersDramaPreferences,
    numberOfChangingRequests,
    numberOfChangingUsers,
    newActionPreferences,
    newActionPreferences
);

movieWatchers.Print();