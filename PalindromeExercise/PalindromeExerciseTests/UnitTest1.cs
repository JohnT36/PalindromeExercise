using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("starfire", false)]
        public void IsPalindromeTest(string word, bool expected)
        {
            var WordSmith = new WordSmith();

            var actual = WordSmith.IsPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
