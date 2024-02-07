using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0)
            {
                throw new ArgumentException("Parameter 'n' cannot be zero.");
            }

            if (startNumber % n == 0)
            {
                return startNumber + n;
            }
            else
            {
                return startNumber + (n - (startNumber % n));
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(IEnumerable<Business> businesses)
        {
            if (businesses == null)
            {
                throw new ArgumentNullException(nameof(businesses));
            }

            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 1)
            {
                return true; // An empty array or a single element array is considered ascending.
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 2)
            {
                return 0; // Not enough elements to find two numbers following an even number.
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1] + numbers[i + 2];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return ""; // No words to form a sentence.
            }

            string sentence = string.Join(" ", words.Where(w => !string.IsNullOrWhiteSpace(w)));

            // Capitalize the first letter of the sentence.
            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            // Add a period at the end if there isn't one.
            if (!sentence.EndsWith("."))
            {
                sentence += ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
            {
                return new double[0]; // Not enough elements to get every fourth element.
            }

            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false; // Not enough elements to find two different elements.
            }

            HashSet<int> seen = new HashSet<int>();
            foreach (int num in nums)
            {
                if (seen.Contains(targetNumber - num))
                {
                    return true;
                }

                seen.Add(num);
            }

            return false;
        }
    }
}
