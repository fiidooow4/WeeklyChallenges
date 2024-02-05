using System;
using System.Collections.Generic;
using System.Linq;
using ChallengesWithTestsMark8;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet02Tests
    {
        // ... other test methods ...

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, true)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, false)]
        [InlineData(new int[] { 1, -2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, true)]
        [InlineData(new int[] { 1, 3, 5, 8 }, true)]
        [InlineData(new int[] { 10, 10, 10, 10 }, false)]
        [InlineData(new int[] { 0, 1, 0 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void IsSumOdd(int[] numbers, bool expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();
            List<int> numbersList = numbers == null ? null : new List<int>(numbers);

            // Act
            bool actual = challenger.IsSumOdd(numbersList);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(5, 2)]
        [InlineData(6, 3)]
        [InlineData(7, 3)]
        [InlineData(1999999999, 999999999)]
        [InlineData(2000000000, 1000000000)]
        [InlineData(-1, 0)]
        [InlineData(-4, 0)]
        [InlineData(-1000, 0)]
        public void CountOfPositiveOddsBelowNumber(int number, int expected)
        {
            // Arrange
            ChallengesSet02 challenger = new ChallengesSet02();

            // Act
            long actual = challenger.CountOfPositiveOddsBelowNumber(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
