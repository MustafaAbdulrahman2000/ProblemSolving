using Problem_002.Services;
using Problem_002.Extensions;

int testCases = Convert.ToInt32(Console.ReadLine()); // 4
var results = new List<string>();

for (int i = 0; i < testCases; i++) // 0
{
    var numberOfCards = Convert.ToInt32(Console.ReadLine()); // 4
    var numberOfActions = Convert.ToInt32(Console.ReadLine()); // 2

    var actions = Console.ReadLine(); // 01

    // 1) Prepare n arrays.
    var cards =  DeckProblemExtensions.PrepareCardsArray(numberOfCards); // 1, 2, 3, 4
    var states = DeckProblemExtensions.PrepareStatesArray(numberOfCards);

    // 2) Solve the problem.
    IDeckProblemSolver solver = new DeckProblemSolver();

    var temp = solver.Solve(cards, actions!, states); // [1, 2, 3, 4], 01
    
    Console.WriteLine(states);
    
    // 3) Store the results.
    results.Add(states.ToString()!); 
}

// 4) Print the results.
results.Print();