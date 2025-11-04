using Problem_009.Common;

namespace Problem_009.Services;

public class ReverseIntegerProblemSolver : IReverseIntegerProblemSolver
{
    private (int, string) GetSignAndDigitsIntoStringFormat(int number)
    {
        if (number < 0)
            return (-1, number.ToString()[1..]);

        return (1, number.ToString()); // 1, 123
    }

    private string ReverseNumberDigitsInStringFormat(string numberDigits)
        => new string(numberDigits.Reverse().ToArray()); // 321

    public int Solve(int number) // 123
    {
        var sign = 0;
        var numberDigitsInStringFormat = "";

        (sign, numberDigitsInStringFormat) = GetSignAndDigitsIntoStringFormat(number);

        var reversedNumberDigitsInStringFormat = ReverseNumberDigitsInStringFormat(numberDigitsInStringFormat);

        var reversedNumberDigits = 0;

        if (int.TryParse(reversedNumberDigitsInStringFormat, out reversedNumberDigits))
        {
            if (reversedNumberDigits < ReverseIntegerConstants.LowestBound || reversedNumberDigits > ReverseIntegerConstants.HighestBound)
                return 0;

            return sign * reversedNumberDigits;
        }

        return 0;
    }
}
