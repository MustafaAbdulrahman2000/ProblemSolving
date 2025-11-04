string input;
int queries;
int counter = 0;

int [] frequency = new int[100000];
int [] firstIndex = new int[100000];
int [] secondIndex = new int[100000];

input = Console.ReadLine();
queries = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < queries; ++i)
{
    firstIndex[i] = Convert.ToInt32(Console.ReadLine());
    secondIndex[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("===============================================");

for (int i = 0; i < queries; ++i)
{
    for (int j = firstIndex[i] - 1; j <= secondIndex[i] - 1; ++j)
        if (input[j] == 'a')
            counter++;
    
    frequency[i] = counter;
    counter = 0;
    
    Console.WriteLine(frequency[i]);
}