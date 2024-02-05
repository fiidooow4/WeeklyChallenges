using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                throw new ArgumentNullException(nameof(vals), "Input array cannot be null.");
            }

            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "Input collection cannot be null.");
            }

            int sum = numbers.Where(n => n % 2 != 0).Sum();
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }

                if (hasUpper && hasLower && hasNumber)
                {
                    return true; // Password contains uppercase, lowercase, and a number
                }
            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.", nameof(val));
            }

            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                throw new ArgumentException("Input string cannot be null or empty.", nameof(val));
            }

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.", nameof(divisor));
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty.", nameof(nums));
            }

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null)
            {
                throw new ArgumentNullException(nameof(words), "Input array cannot be null.");
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
