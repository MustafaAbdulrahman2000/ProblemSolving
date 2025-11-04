using Problem_002.Common;

namespace Problem_002.Services;

public class DeckProblemSolver : IDeckProblemSolver
{
    // [1, 2, 3. 4, 5, 6, 7] - [0, 1, 2, 0, 1] - [+, +, +, +, +, +, +]
    // [1, 2, 3. 4, 5, 6, 7] - [0, 1, 2, 0, 1] - [-, +, +, +, +, +, +]
    // [1, 2, 3. 4, 5, 6, 7] - [1, 2, 0, 1] - [-, +, +, +, +, +, -]
    // [1, 2, 3. 4, 5, 6, 7] - [2, 0, 1] - [-, ?, +, +, +, ?, -]
    // [1, 2, 3. 4, 5, 6, 7] - [0, 1] - [-, -, ?, +, +, ?, -]
    // [1, 2, 3. 4, 5, 6, 7] - [1] - [-, -, ?, +, ?, -, -]
    public string Solve(int[] cards, string actions, char[] states) 
    {
        if (cards.Length == 1 && actions.Length == 1)
        {
            states[0] = DeckProblemConstants.RemovedState;
            return states.ToString()!;
        }

        else
        {
            var top = 0; // 0
            var previousTop = top; // 0

            var bottom = (cards.Length - 1); // 6
            var previousBottom = bottom; // 6

            for (int i = 0; i < actions.Length; i++) // 0 .. 6
            {
                if (actions[i] == DeckProblemConstants.RemoveTopAction && states[previousTop] != DeckProblemConstants.UnknownState)
                {
                    states[top] = DeckProblemConstants.RemovedState;

                    if (top == previousTop) // 0 == 0
                    {
                        top++; // 1
                    }
                    else
                    {
                        top++;
                        previousTop++;
                    }
                }

                else if (actions[i] == DeckProblemConstants.RemoveTopAction && states[previousTop] == DeckProblemConstants.UnknownState)
                {
                    states[previousTop++] = DeckProblemConstants.RemovedState; // previousTop = 2
                    states[top++] = DeckProblemConstants.UnknownState; // top = 3
                }

                else if (actions[i] == DeckProblemConstants.RemoveBottomAction && states[previousBottom] != DeckProblemConstants.UnknownState)
                {
                    states[bottom] = DeckProblemConstants.RemovedState;

                    if (bottom == previousBottom) // 6 == 6
                    {
                        bottom--; // 5
                    }
                    else
                    {
                        bottom--;
                        previousBottom--;
                    }
                }

                else if (actions[i] == DeckProblemConstants.RemoveBottomAction && states[previousBottom] == DeckProblemConstants.UnknownState)
                {
                    states[previousBottom--] = DeckProblemConstants.RemovedState; // previousBottom = 4
                    states[bottom--] = DeckProblemConstants.UnknownState; // bottom = 3
                }

                else if (actions[i] == DeckProblemConstants.RemoveTopOrBottomAction)
                {
                    states[top] = DeckProblemConstants.UnknownState;

                    if (top == previousTop) // 1 == 0
                    {
                        top++; // 1
                    }
                    else
                    {
                        top++; // 2
                        previousTop++; // 1
                    }

                    states[bottom] = DeckProblemConstants.UnknownState;

                    if (bottom == previousBottom) // 5 == 6
                    {
                        bottom--;
                    }
                    else
                    {
                        bottom--; // 4
                        previousBottom--; // 5
                    }
                }
            }

            return states.ToString()!;
        }
    }
}
