using Problem_002.Extensions;

int [] Days = new int[50];
int Counter = 0;
int Flag = 0;
int TestCases;

String [] Tests = new String[50];
String []Distinct = new String[50];
String Previous = "";

TestCases = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < TestCases; ++i)
{
    Days[i] = Convert.ToInt32(Console.ReadLine());
    Tests[i] = Console.ReadLine()!;
    Distinct[i] = ProblemExtensions.FindDistinctLetters(Tests[i]);
}

for(int i = 0; i < TestCases; ++i)
{
    for(int j = 0; j < Tests[i].Length; ++j)
    {
        if(Tests[i][j] == Distinct[i][Counter]) // Y - Z
            continue;
        
        else if(Tests[i][j] != Distinct[i][Counter]) // Y - Z
        {
            if(Previous == "")
            {
                Previous += Distinct[i][Counter];
                Previous += Tests[i][j]; // G
                Counter++; // 1
            }
            else if (Previous != "" && Previous.IndexOf(Tests[i][j]) == -1)
            {
                Previous += Tests[i][j]; // G Z Y
                Counter++; // 3
            }
            else if (Previous != "" && Previous.IndexOf(Tests[i][j]) != -1)
            {
                Flag = 1;
                goto PrintLabel;
            }
        }
    }
    
    PrintLabel:
        if(Flag == 1)
            Console.WriteLine("NO");

        else
            Console.WriteLine("Yes");

        Counter = 0;
        Flag = 0;
        Previous = "";    
}