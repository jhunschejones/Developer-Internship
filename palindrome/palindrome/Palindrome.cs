using System;

namespace Palindrome // NOTE: Namespaces in C# are PascalCased (starting with a captial letter)
{
    public class PalindromeChecker
    {
        // NOTE: XML comments can be used, just be aware.

        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>


        // I am calling this function to reverse the string without using arrays
        public string ReverseString(string input)
        {
            var Reversed = "";

            foreach (char c in input)
            {
                Reversed = c.ToString() + Reversed;
            }

            return Reversed;
        }

        public bool IsPalindrome(string myString)
        { 
            // NOTE, Most C# code uses BSD style, in which braces for a new function are on a new line.
            // This is different than Javascript. 

            // Null strings are not palindrome.
            if (myString == null)
            {
                return false;
            }

            // NOTE: This line has a problem: if (string.IsNullOrEmpty(myString) && myString != "")
            // If string.IsNullOrEmpty is true, then myString != "" is always false. 
            // We already checked for null, here, so we can just go to the next case. 

            // Empty and strings of one character are always palindromes.
            if (myString.Length < 2)
            {
                return true;
            }

            // NOTE: It is worth try to code without using reverse (or writing reverse yourself).

            // convert string to array, reverse, convert back to string
            //char[] myArray = myString.ToCharArray();
            //Array.Reverse(myArray);
            //string myStringReverse = new string(myArray);



            // Note: We can just return of the comparison here. 
            // If they are equal, the string is a palindrome, if not, the string is not. 

            return myString == ReverseString(myString);
        }

    }
}
