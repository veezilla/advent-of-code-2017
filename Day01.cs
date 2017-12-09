using System;

namespace advent_of_code.Days
{
    public class DayOne
    {
        public static int PartOne(string puzzleInput)
        {
            puzzleInput = puzzleInput + puzzleInput[0];

            var sum = 0;
            for (int i = 0; i < puzzleInput.Length - 1; i++)
            {
                if (puzzleInput[i] == puzzleInput[i + 1])
                {
                    sum += (int)Char.GetNumericValue(puzzleInput[i]);
                }
            }
            return sum;
        }

        public static int PartTwo(string puzzleInput)
        {
            if (puzzleInput.Length % 2 == 1)
            {
                throw new NotSupportedException("Odd length input is not supported");
            }

            var inputLength = puzzleInput.Length;
            var halfway = inputLength / 2;
            puzzleInput = puzzleInput + puzzleInput;

            var sum = 0;
            for (int i = 0; i < inputLength; i++)
            {
                if (puzzleInput[i] == puzzleInput[i + halfway])
                {
                    sum += (int)Char.GetNumericValue(puzzleInput[i]);
                }
            }
            return sum;
        }
    }
}