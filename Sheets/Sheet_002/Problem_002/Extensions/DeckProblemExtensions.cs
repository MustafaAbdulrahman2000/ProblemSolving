namespace Problem_002.Extensions;

public static class DeckProblemExtensions
{
    public static int[] PrepareCardsArray(int numberOfCards) // 4
    {
        int[] cardsArray = new int[numberOfCards];

        for (int i = 0; i < numberOfCards; i++)
            cardsArray[i] = (i + 1); // c[0] = 1, c[1] = 2, c[2] = 3, c[3] = 4.

        return cardsArray; // 1, 2, 3, 4.
    }

    public static char[] PrepareStatesArray(int numberOfCards) // 4
    {
        char[] statesArray = new char[numberOfCards];

        for (int i = 0; i < numberOfCards; i++)
            statesArray[i] = '+'; 
            
        return statesArray;
    }

    public static void Print(this IEnumerable<string> results)
    {
        foreach (var item in results)
            Console.WriteLine(item);
    }
}
