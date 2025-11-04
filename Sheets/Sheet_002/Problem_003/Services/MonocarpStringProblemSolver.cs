namespace Problem_003.Services;

public class MonocarpStringProblemSolver : IMonocarpStringProblemSolver
{   
    // aabbaaabbaab 
    private int CalculateNumberOfSomeCharacter(char[] text, char character)
    {
        var counter = 0; // 0

        for (int i = 0; i < text.Length; i++) // b
            if (text[i] == character) // a == a 
                counter++; // 7

        return counter; // 7
    }
    // aabbaaabbaab a 2
    private int CalculateNumberOfConsecutiveCharacters(char[] text, char character, int difference)
    {
        var counter = 0; // 0

        for (int i = 0; i < text.Length - 1; i++) // aabbaaabbaab 
        {
            if (text[i] == character) // b == a
                counter++; // 2

            else if (text[i] != character && counter < difference)
                counter = 0; // 0

            else if (text[i] != character && counter >= difference)
                return counter; // 2
        }

        return -1;
    }

    public int Solve(char[] text)
    {
        if (text.Length == 1) // 12 == 1
            return -1;

        else
        {
            if (text.Distinct().Count() == 1) // 2 == 1
                return -1;

            var sumOfAs = CalculateNumberOfSomeCharacter(text, 'a'); // 7

            var sumOfBs = text.Length - sumOfAs; // 5 

            if (sumOfAs == sumOfBs) // 7 == 5
                return 0; // 0

            // 
            var minimumCharacterValue = (sumOfAs > sumOfBs) ? 'b' : 'a'; // b

            var maximumCharacterValue = (minimumCharacterValue == 'a') ? 'b' : 'a'; // a

            var minimumValue = (minimumCharacterValue == 'a') ? sumOfAs : sumOfBs; // 5

            var maximumValue = text.Length - minimumValue; // 7

            var difference = maximumValue - minimumValue; // 2

            return CalculateNumberOfConsecutiveCharacters(text, maximumCharacterValue, difference); // aabbaaabbaab a 5
        }
    }
}
