using Problem_014.Extensions;

int testCases;
int minimum;
int maximum;
int minimumIndex;
int maximumIndex;
int betweenDistance;
int leftDistance;
int rightDistance;
int firstDistance;
int secondDistance;

int [] stones  = new int[100];
int [] powers  = new int[100];
int [] results = new int[100];

testCases = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < testCases; ++i)
{
    stones[i] = Convert.ToInt32(Console.ReadLine());
    
    for (int j = 0; j < stones[i]; ++j)
        powers[j] = Convert.ToInt32(Console.ReadLine());
    
    minimum = ProblemExtensions.FindMinimum(powers);
    maximum = ProblemExtensions.FindMaximum(powers);
    
    minimumIndex = Array.IndexOf(powers, minimum);
    maximumIndex = Array.IndexOf(powers, maximum);
    
    if (minimumIndex < maximumIndex)
    {
        betweenDistance = (maximumIndex - minimumIndex) + 1; // 2
        leftDistance = minimumIndex + 1; // 1
        rightDistance = ((stones[i] - 1) - maximumIndex) + 1; 
    }
    else
    {
        betweenDistance = (minimumIndex - maximumIndex) + 1;
        leftDistance = maximumIndex + 1;
        rightDistance = ((stones[i] - 1) - minimumIndex) + 1; 
    }
    
    if (leftDistance < rightDistance)
        firstDistance = leftDistance + betweenDistance - 1;
    else
        firstDistance = betweenDistance + rightDistance - 1;
    
    secondDistance = leftDistance + rightDistance;
    
    if (firstDistance <= secondDistance)
        results[i] = firstDistance;
    else
        results[i] = secondDistance;
}

Console.WriteLine("==============================================");

for (int i = 0; i < testCases; ++i)
    Console.WriteLine(results[i]);