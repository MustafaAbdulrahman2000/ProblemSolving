int arraySize;
int queriesNumber;
int firstIndex;
int secondIndex;
int value;

int [] arrayValues = new int[100000];

arraySize = Convert.ToInt32(Console.ReadLine());
queriesNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arraySize; ++i)
    arrayValues[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < queriesNumber; ++i)
{
    firstIndex = Convert.ToInt32(Console.ReadLine());
    secondIndex = Convert.ToInt32(Console.ReadLine());
    value = Convert.ToInt32(Console.ReadLine());
    
    for (int j = firstIndex - 1; j <= secondIndex - 1; ++j)
        arrayValues[j] += value;
}

Console.WriteLine("====================================================");

for (int i = 0; i < arraySize; ++i)
    Console.Write(arrayValues[i] + " ");