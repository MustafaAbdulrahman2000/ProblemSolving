namespace Problem_017.Services;

public static class ProblemSolver
{
    public static void Solve()
    {
        var exercises = 0;
        var chestScore = 0;
        var bicepsScore = 0;
        var backScore = 0;
        
        var muscleExercises = new int[20];
        
        exercises = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < exercises; ++i)
        {
            muscleExercises[i] = Convert.ToInt32(Console.ReadLine());
            
            if (i % 3 == 0)
                chestScore += muscleExercises[i];
            
            else if (i % 3 == 1)
                bicepsScore += muscleExercises[i];

            else if (i % 3 == 2)
                backScore += muscleExercises[i];
        }
        
        if (chestScore > bicepsScore && chestScore > backScore)
            Console.WriteLine("chest");

        if (bicepsScore > chestScore && bicepsScore > backScore)
            Console.WriteLine("biceps");
        
        if (backScore > bicepsScore && backScore > chestScore)
            Console.WriteLine("back");
    }
}
