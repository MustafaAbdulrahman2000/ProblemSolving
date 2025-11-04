int snacks;
int days;
int requiredSize;
int counter = 0;

int [] snackSizes = new int[100000];

snacks = Convert.ToInt32(Console.ReadLine());
days = Snacks;
requiredSize = Snacks;

for (int i = 0; i < snacks; ++i)
    snackSizes[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("============================================");

// 3 1 2 
// 3

for (int i = 0; i < snacks; ++i) 
{
    if (requiredSize == snackSizes[i]) // 2 == 1
    {
        for (int j = counter; j >= 0; j--) 
        {
            if (requiredSize != 0)
                Console.Write(requiredSize + " "); // 3 
            
            requiredSize--; // 2
        }

        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("");
        
        counter++; // 2
    }
}