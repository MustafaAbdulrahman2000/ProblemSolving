namespace Problem_019.Services;

public static class ProblemSolver
{
    private static List<string> CalculateFounders(string input) // 15
    {
        var founders = new List<string>();
        
        var temp1 = "";
        
        var input1 = Convert.ToInt32(input); // 15
        var temp2 = 0;
        
        for (int i = 1; i < Convert.ToInt32(input)/2; ++i) // 1 ... 7 
        {
            temp2 = input1 - i; // 8 
            
            temp1 = i.ToString() + temp2.ToString(); 
            
            if (CheckValue(temp1, input1) == 1)
                founders.Add(temp1);
            
            temp1 =  temp2.ToString() + i.ToString();  
            
            if (CheckValue(temp1, input1) == 1)
                founders.Add(temp1);    
        }
        
        return founders;
    }
    private static List<int> CalculateUnique(List<int> numbers)
    {
        var unique = new List<int>();
        
        for (int i = 0; i < numbers.Count; ++i)
        {
            int temp = numbers.ElementAt(i);
            
            if (CheckUniqueness(temp) == 1)
                unique.Add(temp);
        }
        
        return unique;
    }
    private static int CheckUniqueness(int number)
    {
        var temp = number.ToString();
        
        for(int i = 0; i < temp.Length; ++i)
            for (int j = 0; j < temp.Length; ++j)
                if (i != j && temp[i] == temp[j])
                    return 0;
        
        return 1;
    }
    private static int CheckValue(string number, int value)
    {
        var sum = 0; 
        
        for (int i = 0; i < number.Length; ++i)
            sum += Convert.ToInt32(new string(number[i],1));

        return (sum == value) ? 1 : 0;
    } 

    public static void Solve()
    {
        var testCases = Convert.ToInt32(Console.ReadLine());
        
        var inputs = new string[testCases];
        var results = new int[testCases];
        
        var founders = new List<string>();
        
        var numbers = new List<int>();
        var uniques = new List<int>();
        
        for (int i = 0; i < testCases; ++i)
        {
            inputs[i] = Console.ReadLine()!;
            
            if (inputs[i].Length == 1)
                results[i] = Convert.ToInt32(inputs[i]);
            
            else
            {
                founders = CalculateFounders(inputs[i]);
            
                for (int j = 0; j < founders.Count; ++j)
                    numbers.Add(Convert.ToInt32(founders.ElementAt(j)));        
                
                uniques = CalculateUnique(numbers);
                
                if (uniques.Count == 0)
                    results[i] = -1;

                else
                    results[i] = uniques.AsQueryable().Min();
            }
            
            founders.Clear();
            numbers.Clear();
            uniques.Clear();
        }
        
        Console.WriteLine("===================================================");
        
        for(int i = 0; i < testCases; ++i)
            Console.WriteLine(results[i]);
    }

}

/*

    
    
    
    
    
    
    
    static void Main() 
    {
        
    }


*/
