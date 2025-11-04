namespace Problem_004.Services;

public interface IPredictingPopularityProblemSolver
{
    IEnumerable<int> Solve(int actionRating, int dramaRating, int numberOfUsers, int[] usersActionPreferences, int[] usersDramaPreferences, int numberOfChangingRequests, int[] numberOfChangingUser, int[] newActionPreference, int[] newDramaPreference, int popularity = 0);
}
