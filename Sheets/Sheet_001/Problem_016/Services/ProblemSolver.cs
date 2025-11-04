namespace Problem_016.Services;

public static class ProblemSolver
{
    private static string[] ConstructsubStrings(string input, int length)
    {
        var start = 0;
        var end = 0;
        var counter1 = 0;
        var counter2 = 0;
        var Temp = 0;
        
        var subStrings = new string[100];
        
        start = length - 1;
        end = (2 * start) ;
        
        for (int i = start; i <= end; ++i)
        {
            for (;counter1 <= i; ++counter1)
                subStrings[counter2] += input[counter1]; 
            
            counter2++;
            Temp++; 
            counter1 = Temp;
        }
        
        return subStrings;
    }
    private static string[] ConstructNewString(int length)
    {
        var temp = 0;
        var difference = 0;
        
        
        var truthTable = new string [(int)Math.Pow(2, length)];
        
        truthTable[0] = "0";

        for (int j = 1; j < (int)Math.Pow(2, length); ++j) // 15
        {
            temp = (int) j; // 0
            
            for (int i = 0; temp > 0; i++)
            {
                truthTable[j] = temp % 2 + truthTable[j];

                temp = temp / 2;
            }
        }
        
        for (int i = 0; i < truthTable.Length; ++i)
        {
            if (length - truthTable[i].Length != 0)
            {
               difference = length - truthTable[i].Length; // 2
               
               for (int j = 0; j < difference; ++j)
                   truthTable[i] = "0" + truthTable[i];
            }
        }
        
        return truthTable;
    }
    private static int CheckSimilarity(string input1, string input2)
    {
        for (int i = 0; i < input1.Length; ++i)
            if (input1[i] == input2[i])
                return 1;

        return 0;
    }

    public static void Solve()
    {
        var length = Convert.ToInt32(Console.ReadLine());
        
        var input = new char[100];
        
        for (int i = 0; i < (2 * length) - 1; ++i)
            input[i] = Console.ReadLine()![0]; 
        
        var inputString = new string(input);
        
        var subStrings = ConstructsubStrings(inputString, length);
        
        var newStrings = ConstructNewString(length);
        
        var flag = 0;
        
        for (int i = 0; i < newStrings.Length; ++i) // 1
        {
            for (int j = 0; j < length; ++j) // 1
                if (CheckSimilarity(newStrings[i], subStrings[j]) == 0)
                    flag++;

            if (flag == 0)
            {
                Console.WriteLine("==========================================");
                
                Console.WriteLine(newStrings[i]);
                
                break;
            }

            flag = 0;
        }
    } 
}
