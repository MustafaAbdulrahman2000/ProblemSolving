namespace Problem_005.Services;

public class RecursiveQueriesProblemSolver : IRecursiveQueriesProblemSolver
{
    private int ProductNumberNonzeroDigitis(int number)
    {
        var productOfNonzeroDigits = 1;

        var remainder = 0;

        while (number > 0)
        {
            remainder = number % 10;
            
            if (remainder != 0)
                productOfNonzeroDigits *= remainder;

            number /= 10; 
        }

        return productOfNonzeroDigits;
    }

    private int RecursiveMethod(int number)
    {
        if (number < 10)
            return number;

        var functionOfNumber = ProductNumberNonzeroDigitis(number);

        return RecursiveMethod(functionOfNumber);
    }

    public IEnumerable<int> Solve(int numberOfQueries, int[] leftEdges, int[] rightEdges, int[] middleValues)
    {
        var results = new List<int>();
        var counter = 0;

        for (int i = 0; i < numberOfQueries; i++)
        {
            for (int j = leftEdges[i]; j <= rightEdges[i]; j++)
            {
                if (RecursiveMethod(j) == middleValues[i])
                    counter++;
            }

            results.Add(counter);
            counter = 0;
        }

        return results;
    }
}
