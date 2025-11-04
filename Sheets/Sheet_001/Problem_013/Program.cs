int testCases;
int counter = 1;
int index = 0;

int [] tests = new int[1000];
int [] sequence = new int[1000];

testCases = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < testCases; ++i)
    tests[i] = Convert.ToInt32(Console.ReadLine()); 

for (counter = 1; counter <= 1666; ++counter)
{
    if (counter % 3 == 0 || (counter - 3)% 10 == 0)
        continue;
    else
        sequence[index++] = counter;
}

Console.WriteLine("=======================================================");

for (int i = 0; i < testCases; ++i)
    Console.WriteLine(sequence[tests[i] - 1]);