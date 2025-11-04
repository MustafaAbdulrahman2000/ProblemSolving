namespace Problem_004.Services;

public class PredictingPopularityProblemSolver : IPredictingPopularityProblemSolver
{
    private bool CheckMovieSuitablityOfUser(
        int userActionPreference, // 1
        int userDramaPreference, // 50
        int actionRating, // 20
        int dramaRating, // 25
        int popularity // 1
    )
    {
        // max(1 - 20, 0) + max(50 - 25, 0) <= 1 => false
        return Math.Max(userActionPreference - actionRating, 0) + Math.Max(userDramaPreference - dramaRating, 0) <= popularity;
    }

    private IEnumerable<int> PrepareNonSuitablePositions(int numberOfUsers) // 4
    {
        var nonSuitablePositions = new List<int>();

        for (int i = 0; i < numberOfUsers; i++) // 0 1 2 3
            nonSuitablePositions.Add(i);

        return nonSuitablePositions; // [0, 1, 2, 3]
    }

    private int UpdatePopularity(
        int actionRating, // 20
        int dramaRating, // 25
        int numberOfUsers, // 4
        int[] usersActionPreferences, // 1 22 1 30
        int[] usersDramaPreferences, // 1 22 50 30
        List<int> nonSuitablePositions, // [0, 1, 2, 3]
        int popularity // 0
    )
    {
        int currentUserPosition = 0; // 0

        while (popularity < numberOfUsers && currentUserPosition < numberOfUsers)
        {   // 1 < 4

            var suitability = CheckMovieSuitablityOfUser(usersActionPreferences[currentUserPosition], usersDramaPreferences[currentUserPosition], actionRating, dramaRating, popularity);

            if (suitability) // false
            {
                nonSuitablePositions!.Remove(currentUserPosition); // [1, 2, 3] 

                currentUserPosition = nonSuitablePositions.ElementAt(0); // 1

                popularity++; // 1
            }

            else
            {
                currentUserPosition++; // 4
            }
        }
        return popularity; // 1
    }

    public IEnumerable<int> Solve(
        int actionRating, // 20
        int dramaRating, // 25
        int numberOfUsers, // 4
        int[] usersActionPreferences, // 1 22 1 30
        int[] usersDramaPreferences, // 1 22 50 30
        int numberOfChangingRequests, // 5
        int[] numberOfChangingUser, // 3 2 4 1 3
        int[] newActionPreference, // 1 23 10 21 20
        int[] newDramaPreference, // 25 22 27 21 26
        int popularity = 0 // 0
    )
    {
        /*

            20 25
            4
            1 22 1 30
            1 22 50 30
            5 
            3 1  25
            2 23 22
            4 10 27
            1 21 21
            3 20 26

        */

        var nonSuitablePositions = PrepareNonSuitablePositions(numberOfUsers) as List<int>; // [0, 1, 2, 3]

        var movieWatchers = UpdatePopularity(actionRating, dramaRating, numberOfUsers, usersActionPreferences, usersDramaPreferences, nonSuitablePositions!, popularity); // 1

        var results = new List<int>();

        for (int i = 0; i < numberOfChangingRequests; i++) // 0 1 2 3 4
        {
            usersActionPreferences[numberOfChangingUser[i] - 1] = newActionPreference[i]; // 1

            usersDramaPreferences[numberOfChangingUser[i] - 1] = newDramaPreference[i]; // 25

            results.Add(UpdatePopularity(actionRating, dramaRating, numberOfUsers, usersActionPreferences, usersDramaPreferences, nonSuitablePositions!, movieWatchers));
        }

        return results;
    }
}