using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (ignoreCase)
            {
                return words.Any(w => string.Equals(w, word, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num <= 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char currentChar = str[i];
                if (str.Count(c => c == currentChar) == 1)
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }

            List<double> result = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
