String Heading;
String Text;
String Temp;
    
Dictionary<String,int> FrequencyDictionary = new  Dictionary<String,int>();
    
int Count1 = 0;
int Count2 = 0;
int Flag = 0;

Heading = Console.ReadLine()!;
Text = Console.ReadLine()!;
    
for (int i = 0; i < Text!.Length; ++i) // where is your dog
{
    if (Text[i] == ' ')
        continue;
    
    else if (Text[i] != ' ' && FrequencyDictionary.ContainsKey(Char.ToString(Text[i])) == false)
    {
        Count1 = 1;
        FrequencyDictionary.Add(Char.ToString(Text[i]),Count1);
    }
        
    else if (Text[i] != ' ' && FrequencyDictionary.ContainsKey(Char.ToString(Text[i])) == true)
    {
        Count1 = FrequencyDictionary[Char.ToString(Text[i])]; // 1
        Count1++; // 2
        
        FrequencyDictionary[Char.ToString(Text[i])] = Count1; // 2
    }
    
}
    
for (int i = 0; i < FrequencyDictionary.Count; ++i)
{
    Temp = FrequencyDictionary.Keys.ElementAt(i);
    for (int j = 0; j < Heading!.Length; ++j)
    {
        if (Char.ToString(Heading[j]) == Temp)
        {
            Count2++;
        }
    }
    
    if(Count2 < FrequencyDictionary[Temp])
    {
        Flag = 1;
        break;
    }
    
    Count2 = 0;
}
   
if (Flag == 0)
        Console.WriteLine("YES");
    
else
    Console.WriteLine("NO");