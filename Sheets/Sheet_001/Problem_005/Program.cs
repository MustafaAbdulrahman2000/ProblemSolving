int Pairs;
int Maximum = 0;

int [] Order = new int [200000];
List<int> Table = new List<int>();

Pairs = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 2 * Pairs; ++i)
{
    Order[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 2 * Pairs; ++i) // 1 1
{
    if(Table.Contains(Order[i]) == false) // 1
        Table.Add(Order[i]); // 

    else if (Table.Contains(Order[i]) == true) // 1
        Table.Remove(Order[i]); // Empty

    if (Table.Count > Maximum) // 0 > 1
        Maximum = Table.Count; // 1   
}

Console.WriteLine("==================================================="); 
Console.WriteLine(Maximum); // 1