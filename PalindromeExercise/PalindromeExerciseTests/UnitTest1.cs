using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("lol", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //arrange
            var wordSmith = new WordSmith();
            //act
            bool actual = wordSmith.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
