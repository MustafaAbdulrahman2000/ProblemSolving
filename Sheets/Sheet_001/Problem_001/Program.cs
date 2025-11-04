using Problem_001.Extensions;

int TestCases;
        
String Text = "";
String[] Tests = new String[50];

int RepeatedLetters;
int RemainingDistinctLetters;
int Result = 0;

TestCases = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < TestCases; ++i)
{
    Text = Console.ReadLine()!;
    
    (RepeatedLetters,RemainingDistinctLetters) = ProblemExtensions.FindRepeatedLetters(Text);
    
    if(ProblemExtensions.FindDistinct(Text) == 1)
        Result = Text.Length /2;

    else
    {
        Result += RepeatedLetters;
        Result += (RemainingDistinctLetters / 2);
    }

    Console.WriteLine(Result);
    
    Result = 0;
}	        
