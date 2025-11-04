using Problem_010.Common;

namespace Problem_010.Services;

public class AtoiProblemSolver : IAtoiProblemSolver
{
    private bool CheckExistingOfLeadingCharacter(char input, char character)
        => (input == character);
    private int GetFirstCharacterAfterSpecificCharacter(string input, char character)
        => input.IndexOf(input.FirstOrDefault(c => c != character));
    private bool CheckSignedness(string input, int firstNonWhitespaceCharacter)
        => (input[firstNonWhitespaceCharacter] == AtoiProblemConstants.Negative ||
              input[firstNonWhitespaceCharacter] == AtoiProblemConstants.Positive);
    private int GetSign(char sign)
        => sign == AtoiProblemConstants.Negative ? -1 : 1;
    private string GetNumericString(string input, int start, int end)
    {
        var numericString = "";

        for (int i = start; i < input.Length; i++)
        {
            if (input[i] >= AtoiProblemConstants.Zero && input[i] <= AtoiProblemConstants.Nine)
                numericString += input[i];
            else
                break;
        }

        return numericString;
    }
    private int RoundIntegerLowerValue()
        => int.MinValue;
    private int RoundIntegerHigherValue()
        => int.MaxValue;

    public int Solve(string input) // -042
    {
        var hasLeadingWhitespaces = CheckExistingOfLeadingCharacter(input[0], AtoiProblemConstants.Whitespace);
        var firstNonWhitespaceCharacter = 0;

        if (hasLeadingWhitespaces)
            firstNonWhitespaceCharacter = GetFirstCharacterAfterSpecificCharacter(input, AtoiProblemConstants.Whitespace);

        var hasSign = CheckSignedness(input, firstNonWhitespaceCharacter);
        var signValue = 1;
        var afterSignIndex = firstNonWhitespaceCharacter;

        if (hasSign)
        {
            signValue = GetSign(input[firstNonWhitespaceCharacter]); // -1
            afterSignIndex++; // 1
        }

        var hasLeadingZeros = CheckExistingOfLeadingCharacter(input[afterSignIndex], AtoiProblemConstants.Zero);
        var firstDigitCharacter = afterSignIndex;

        if (hasLeadingZeros)
            firstDigitCharacter = GetFirstCharacterAfterSpecificCharacter(input, AtoiProblemConstants.Zero);

        var numericString = GetNumericString(input, firstDigitCharacter, input.Length);

        if (int.TryParse(numericString, out var integerValue))
        {
            return signValue * integerValue;
        }

        else
        {
            if (numericString == string.Empty)
                return 0;

            if (signValue == 1)
                return RoundIntegerHigherValue();

            return RoundIntegerLowerValue();
        }
    }
}
