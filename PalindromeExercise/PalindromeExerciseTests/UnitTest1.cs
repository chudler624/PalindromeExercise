using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("radar", true)]
        [InlineData("refer", true)]
        [InlineData("casey", false)]
        [InlineData("football", false)]
        [InlineData("", false)]
        [InlineData(null, false)]// ← you will need to put some test data and expected result here.
        public void PalindromeTest(string palindrome, bool expected)
        {
         //arrange
         var instance = new WordSmith();


            var acutal = instance.IsAPalindrome("racecar");


         //assert

         Assert.Equal(expected, acutal);
        }
    }
}
