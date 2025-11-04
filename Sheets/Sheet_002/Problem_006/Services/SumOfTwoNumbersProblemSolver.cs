using System.Collections.Generic;
using System.Linq;
using Problem_006.Common;
using Problem_006.Models;

namespace Problem_006.Services;

public class SumOfTwoNumbersProblemSolver : ISumOfTwoNumbersProblemSolver
{
    private int CalculateNumberFromLinkedList(NumberLinkedList linkedList)
    {
        var currentNode = linkedList.head;
        var position = 0d;
        var number = 0;
        
        for (int i = 1; i <= linkedList.size; ++i)
        {
            number += currentNode.digit * (int)Math.Pow(SumOfTwoNumbersProblemConstants.DecimalFactor, position);

            position++;

            currentNode = currentNode.next;
        }

        return number;
    }

    private NumberLinkedList ConstructLinkedListFromString(string number)
    {
        var sumLinkedList = new NumberLinkedList();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            var digit = (int)number[i] - SumOfTwoNumbersProblemConstants.CharacterToIntegerFactor;

            sumLinkedList.Add(digit);
        }
     
        return sumLinkedList;
    }

    public NumberLinkedList Solve(NumberLinkedList first, NumberLinkedList second)
    {
        var number1 = CalculateNumberFromLinkedList(first);
        var number2 = CalculateNumberFromLinkedList(second);

        var integerSum = number1 + number2;

        var stringSum = integerSum.ToString();

        return ConstructLinkedListFromString(stringSum!);
    }
}
