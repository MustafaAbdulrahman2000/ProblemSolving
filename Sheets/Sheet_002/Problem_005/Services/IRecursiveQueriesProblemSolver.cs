namespace Problem_005.Services;

public interface IRecursiveQueriesProblemSolver
{
    IEnumerable<int> Solve(int numberOfQueries, int[] leftEdges, int[] rightEdges, int[] middleValues);
}
