namespace Problem_022.Services;

public static class ProblemSolver
{
    public static void Solve()
    {           
        var tempB1 = "";
        var tempB2 = "";
        var tempB3 = "";
        
        var input1 = Convert.ToInt32(Console.ReadLine());
        var input2 = Convert.ToInt32(Console.ReadLine());
        
        var sum1 = input1 + input2;
        
        var tempA1 = input1.ToString();
        var tempA2 = input2.ToString();
        var tempA3 = sum1.ToString();
        
        for (int i = 0; i < tempA1.Length; ++i)
            if (tempA1[i] != '0')
                tempB1 += tempA1[i];
        
        for (int i = 0; i < tempA2.Length; ++i)
            if (tempA2[i] != '0')
                tempB2 += tempA2[i];
        
        for (int i = 0; i < tempA3.Length; ++i)
            if (tempA3[i] != '0')
                tempB3 += tempA3[i];
        
        var output1 = Convert.ToInt32(tempB1);
        var output2 = Convert.ToInt32(tempB2);
        var sum2 = Convert.ToInt32(tempB3);
        
        Console.WriteLine("===================================================");
        
        if (sum2 == (output1 + output2))
            Console.WriteLine("YES");
        
        else 
            Console.WriteLine("NO");

    }
}
