using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
     public bool IsAPalindrome(string mainString)
        {
            string firstHalf = mainString.Substring(0, mainString.Length / 2);
            char[] arr = mainString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            return (firstHalf == secondHalf)? true : false; 
            
            




        }




    }
}
