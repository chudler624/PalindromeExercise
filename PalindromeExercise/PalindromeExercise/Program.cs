using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsmith = new WordSmith();
            bool palindrome = wordsmith.IsAPalindrome("kayak");
            Console.WriteLine(palindrome);
        }

    }

}