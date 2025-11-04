int size;
int queryNumber;
int firstIndex;
int secondIndex;
int summation = 0;
int counter = 0;

int [] elements = new int[100000];
int [] results = new int[100000];

size = Convert.ToInt32(Console.ReadLine());
queryNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < size; ++i)
    elements[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < queryNumber; ++i)
{
    firstIndex = Convert.ToInt32(Console.ReadLine());
    secondIndex = Convert.ToInt32(Console.ReadLine());
    
    for (int j = firstIndex - 1; j <= secondIndex - 1; ++j)
        summation += elements[j];
    
    results[counter++] = summation;
    summation = 0;
}

Console.WriteLine("==============================================================");

for (int i = 0; i < counter; ++i)
    Console.WriteLine(results[i]);
