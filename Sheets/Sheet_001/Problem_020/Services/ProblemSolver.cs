namespace Problem_020.Services;

public static class ProblemSolver
{
    private static int CheckEqual(List<int> numbers, int length)
    {
        var counter = 1;
        
        for (int i = 1; i < length; ++i)
            if (numbers.ElementAt(0) == numbers.ElementAt(i))
                counter++;

        return (counter == length) ? 1 : 0;
    }

    public static void Solve()
    {
        var testCases = 0;
        var length = 0;
        var even = 0;
        var odd = 0;
        
        var columns = new List<int>();
        
        var results = new string[100];
        
        testCases = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < testCases; ++i)
        {
            length = Convert.ToInt32(Console.ReadLine());
            
            for(int j = 0; j < length; ++j)
            {
                columns.Add(Convert.ToInt32(Console.ReadLine()));
                    
                if (columns.ElementAt(j) % 2 == 0)
                    even++;
        
                else 
                    odd++;
            }
            
            if (length == 1)
                results[i] = "YES";
            
            else if (CheckEqual(columns, length) == 1)
                results[i] = "YES";
                
            else if (even == 0 || odd == 0)
                results[i] = "YES";
                
            else
                results[i] = "NO";   
        }
        
        Console.WriteLine("======================================================");
        
        for(int i = 0; i < testCases; ++i)
            Console.WriteLine(results[i]);
    }
}