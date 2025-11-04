namespace Problem_021.Services;

public static class ProblemSolver
{
    public static void Solve()
    { 
        var temp1 = "";
        var temp2 = "";
        var lecture = "";
        var result = "";
        
        var languages = new Dictionary<string, string>();
        
        var lectureWords = Convert.ToInt32(Console.ReadLine());
        var languageWords = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < languageWords; ++i)
        {
            temp1 = Console.ReadLine();
            temp2 = Console.ReadLine();
            
            languages.Add(temp1!, temp2!);
        }
        
        lecture = Console.ReadLine();
        
        var lectureContent = lecture!.Split(" ");
        
        for (int i = 0; i < lectureWords; ++i)
        {
            var temp = languages[lectureContent[i]].Length; 
            
            if (lectureContent[i].Length <= temp)
                result += lectureContent[i] + " ";
            
            else
                result += languages[lectureContent[i]] + " ";
        }
        
        Console.WriteLine("=======================================================================");
        
        Console.WriteLine(result);
    }
}
