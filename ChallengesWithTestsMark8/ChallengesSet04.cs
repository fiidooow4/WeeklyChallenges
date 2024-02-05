using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; // Return 0 for empty array or null input
            }

            int sumEven = 0;
            int sumOdd = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }

            return sumEven - sumOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = new int[]
            {
                (str1 ?? "").Length,
                (str2 ?? "").Length,
                (str3 ?? "").Length,
                (str4 ?? "").Length
            };

            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz != null)
            {
                biz.Name = "TrueCoders";
            }
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            int result;
            return int.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return true; // Return true for empty array or null input
            }

            int countNull = objs.Count(obj => obj == null);
            int countNonNull = objs.Length - countNull;

            return countNull > countNonNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; // Return 0 for empty array or null input
            }

            double sumEven = 0;
            int countEven = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEven += number;
                    countEven++;
                }
            }

            if (countEven == 0)
            {
                return 0; // Return 0 if no even numbers are found
            }

            return sumEven / countEven;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be non-negative.");
            }

            if (number == 0 || number == 1)
            {
                return 1; // Return 1 for factorial of 0 or 1
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
