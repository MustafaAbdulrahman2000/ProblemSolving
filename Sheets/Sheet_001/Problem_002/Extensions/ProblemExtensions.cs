namespace Problem_002.Extensions;

public static class ProblemExtensions
{
    public static String FindDistinctLetters(String Test)
    {
        String Distinct = "";
        
        for(int i = 0; i < Test.Length; ++i)
        {
            if(Distinct.IndexOf(Test[i]) == -1)
                Distinct += Test[i];

            else
                continue;
        }
        
        return Distinct;
    }
}
