String Input;
String Lower = "abcdefghijklmnopqrstuvwxyz";
String Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

int Size;
int Counter = 0;

Size = Convert.ToInt32(Console.ReadLine());
Input = Console.ReadLine()!;

for (int i = 0; i < 26; ++i)
{
    if (Input.IndexOf(Lower[i]) != -1 || Input.IndexOf(Upper[i]) != -1)
    {
        Counter++;
    }
}

if (Counter == 26)
    Console.WriteLine("YES");
else 
    Console.WriteLine("NO");
