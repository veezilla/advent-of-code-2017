using System;
using System.Linq;

namespace advent_of_code.Days
{
    public class DayFour
    {
        public static int PartOne(string puzzleInput)
        {
            int validCount = 0;
            var passphrases = puzzleInput.Split(Environment.NewLine);

            foreach (var passphrase in passphrases)
            {
                if (CheckIfValid(passphrase))
                {
                    validCount += 1;
                }
            }
            return validCount;
        }

        public static int PartTwo(string puzzleInput)
        {
            int validCount = 0;
            var passphrases = puzzleInput.Split(Environment.NewLine);
            
            // todo go through each passphrase and split and update
            foreach (var passphrase in passphrases)
            {
                if (CheckIfValid(passphrase, true))
                {
                    validCount += 1;
                }
            }
            return validCount;
        }

        private static bool CheckIfValid(string passphrase, bool disallowAnagrams = false)
        {
            var splitPassphrase = passphrase.Split(' ');
            bool isPassphraseValid = true;

            if (disallowAnagrams)
            {
                for (int i = 0; i < splitPassphrase.Length; i++)
                {
                    splitPassphrase[i] = String.Concat(splitPassphrase[i].OrderBy(c => c));
                }
            }

            for (int i = 0; i < splitPassphrase.Length; i++)
            {
                if (splitPassphrase.Where(p => p == splitPassphrase[i]).Count() > 1) {
                    isPassphraseValid = false;
                }
            }
            return isPassphraseValid;
        }
    }
}