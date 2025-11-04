int limit;
int queriesNumber;
int temp1;
int temp2;
int counter1 = 0;
int counter2 = 0;

int [] frequencies = new int[100000]; 
Dictionary<int,int> queries = new ();


limit = Convert.ToInt32(Console.ReadLine());
queriesNumber = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < queriesNumber; ++i)
{
    temp1 = Convert.ToInt32(Console.ReadLine()); // 2
    temp2 = Convert.ToInt32(Console.ReadLine()); // 1
    
    if (temp1 == 1 && queries.ContainsKey(temp2) == false)
    {
        counter1 = 1; // 1
        queries.Add(temp2,counter1); // <1,1> <6,1> <3,1>
    }    
    else if (temp1 == 1 && queries.ContainsKey(temp2) == true)
    {
        counter1 = queries[temp2];
        counter1++;
        queries[temp2] = counter1;
    }
    else if (temp1 == 2 && queries.ContainsKey(temp2) == false)
    {
        frequencies[counter2] = 0; 
        counter2++;
    }
    else if (temp1 == 2 && queries.ContainsKey(temp2) == true)
    {
        frequencies[counter2] = queries[temp2]; // 1
        counter2++; //1 
    }
}

Console.WriteLine("=============================================");

for (int i = 0; i < counter2; ++i)
{
    Console.WriteLine(frequencies[i]);
}