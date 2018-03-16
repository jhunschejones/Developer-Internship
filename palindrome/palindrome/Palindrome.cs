using System;

// Note, this is my solution. Please feel free to critique and ask questions.

namespace Palindrome
{ 
    public class PalindromeChecker
    {
        public bool IsPalindrome(string myString)
        { 
            // Null strings are not a palindrome.
            if (myString == null)
            {
                return false;
            }

            // Empty string and strings of one character are always palindromes.
            if (myString.Length < 2)
            {
                return true;
            }

            // Let us try to prove that this is *not* a palindrome. 
            // If we fail, it must be a palindrome. 
            
            // This is a common pattern, to prove the opposite assertion and by failing to 
            // do so, confirm the assertion is true. 

            // Integer division is fine here, even with the round down.
            // We only need to check (about) half of the string to prove it is not
            // a palindrome.

            for (int i = 0; i < myString.Length / 2; i++)
            {
                // If the ith character does not match the Length - i - 1 character, 
                // we don't have a palindrome. Just return false.
               
                if (myString[i] != myString[myString.Length - i - 1])
                {
                    return false;
                }
            }

            // Take some time to analyze how the above works on paper. 
            // Pick a string, and track the values of i, myString.Length - i - 1 
            // and look at the pattern. It seems odd to try to do what a computer
            // will do, but it is a critical skill. 

            // If we made it this far, we must have a palindrome.
            return true;
        }
    }
}
