string input;
string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowerCase = "abcdefghijklmnopqrstuvwxyz";

int counter = 0;
Dictionary<char,int> frequency = new Dictionary<char,int>();

input = Console.ReadLine();

for (int i = 0; i < 26; ++i)
{
    
    if (input.IndexOf(upperCase[i]) != -1)
    {
        for (int j = 0; j < input.Length; ++j)
        {
            if (input[j] != upperCase[i])
                continue;
            else
                Counter++;
        }
        
        frequency.Add(upperCase[i], counter);
        counter = 0;
    } 
}

for (int i = 0; i < 26; ++i)
{    
    if (input.IndexOf(lowerCase[i]) != -1)
    {
        for (int j = 0; j < input.Length; ++j)
        {
            if (input[j] != lowerCase[i])
                continue;
            else
                Counter++;
        }
        
        frequency.Add(lowerCase[i], counter);
        counter = 0;
    }
}

foreach(KeyValuePair<char, int> ele1 in frequency)
    Console.WriteLine("{0}  {1}",ele1.Key, ele1.Value);
