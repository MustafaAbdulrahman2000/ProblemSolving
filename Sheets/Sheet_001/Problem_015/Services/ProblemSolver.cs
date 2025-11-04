namespace Problem_015.Services;

public static class ProblemSolver
{
    public static void Solve()
    {
        var fileNameLength = 0;
        var counter1 = 0;
        var counter2 = 0;
        var minimum = 0;
    
        var fileName = new char[100];

        fileNameLength = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < fileNameLength; ++i)
            fileName[i] = Console.ReadLine()![0];

        var file = new string(fileName);
        
        if (file.Contains("xxx") == false)
            Console.WriteLine(minimum);
        
        else 
        {
            for (int i = 0; i < fileNameLength; ++i)
                if (file[i] == 'x')
                    counter2++;
            
            if (counter2 == fileNameLength)
            {
                minimum = fileNameLength - 2;
                
                Console.WriteLine(minimum);
            }
        
            else 
            {
                for (int i = 0; i < fileNameLength; ++i)
                {
                    if (counter1 == 2)
                    {
                        counter1 = 0;
                        fileName[i] = '0';
                        minimum++;
                    }
            
                    else if (fileName[i] == 'x')
                        counter1++;
                }
        
                Console.WriteLine(minimum);
            }
        }
    }
}
