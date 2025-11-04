namespace Problem_018.Services;

public static class ProblemSolver
{
    public static void Solve()
    {
        var days = 1;
        
        var initialSocks = Convert.ToInt32(Console.ReadLine()); 
        var period = Convert.ToInt32(Console.ReadLine()); 
        var socks = initialSocks; 

        while (socks != 0) 
        {
            socks--; 
            
            if (days % period == 0) 
                socks++;

            days++; 
        }
        
        Console.WriteLine("============================================================");
        
        Console.WriteLine((days - 1));
    }
}
