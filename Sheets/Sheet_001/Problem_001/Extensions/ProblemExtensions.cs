namespace Problem_001.Extensions;

public static class ProblemExtensions
{
    public static (int,int) FindRepeatedLetters(String Text)
    {
        String Temp = "";
        int Flag = 0;
        int Repeated = 0;
        int RemainingDistinct = 0;
        
        for(int i = 0; i < Text.Length; ++i)
        {       	               
            if(Temp.IndexOf(Text[i]) == -1)
            {
                Temp += Text[i];
            }
        }
        
        for(int i = 0; i < Temp.Length; ++i)
        {
            for(int j = 0; j < Text.Length; ++j)
            {
                if(Temp[i] == Text[j])
                {
                    Flag++;
                }
            }
            if(Flag > 1)
            {
                Repeated++;
                Flag = 0;
            }
        }

        RemainingDistinct = Temp.Length - Repeated;
        
        return (Repeated,RemainingDistinct);
    }

    static public int FindDistinct(String Text)
    {
        String Temp = "";
        for(int i = 0; i < Text.Length; ++i)
        {
            if(Temp.IndexOf(Text[i]) == -1)
            {
                Temp += Text[i];
            }
        }   

        if (Temp.Length == Text.Length)
            return 1;
        else 
            return 0;
    }

}
