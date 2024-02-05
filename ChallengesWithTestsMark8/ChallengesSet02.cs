using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null)
                throw new ArgumentNullException(nameof(vals));

            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            double min = numbers.Min();
            double max = numbers.Max();

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                throw new ArgumentNullException("Input strings cannot be null.");

            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.Where(n => n % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                throw new ArgumentNullException(nameof(numbers));

            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
                return 0;

            return number / 2;
        }
    }
}
