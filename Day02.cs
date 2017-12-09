using System;
using System.Linq;

namespace advent_of_code.Days
{
    public class DayTwo
    {
        public static int PartOne(string puzzleInput)
        {
            var puzzleInputLines = puzzleInput.Split(Environment.NewLine);

            var checksum = 0;
            for (int i = 0; i < puzzleInputLines.Length; i++)
            {
                var splitInput  = puzzleInputLines[i].Split('\t');
                var randomNumbers = Array.ConvertAll(splitInput, int.Parse);
                checksum += (randomNumbers.Max() - randomNumbers.Min());
            }

            return checksum;
        }

        public static int PartTwo(string puzzleInput)
        {
            var puzzleInputLines = puzzleInput.Split(Environment.NewLine);

            var checksum = 0;
            for (int i = 0; i < puzzleInputLines.Length; i++)
            {
                var splitInput = puzzleInputLines[i].Split('\t');
                var randomNumbers = Array.ConvertAll(splitInput, int.Parse);

                for (int j = 0; j < randomNumbers.Length; j++)
                {
                    for (int k = j + 1; k < randomNumbers.Length; k++)
                    {
                        if (randomNumbers[j] % randomNumbers[k] == 0 || randomNumbers[k] % randomNumbers[j] == 0)
                        {   
                            // REFACTOR poor readability
                            checksum += randomNumbers[j] > randomNumbers[k] ? randomNumbers[j] / randomNumbers[k] : randomNumbers[k] / randomNumbers[j];
                        }
                    }
                }
            }
            return checksum;
        }
    }
}