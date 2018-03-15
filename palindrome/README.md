# Palindrome Challenge

## Objective
* Create a method that can check if a string is a palindrome or not, assuming input can only be a string or null
* Optimize for short or empty strings
* Create unit tests for method

## Steps taken 
Though a major portion of this challenge was focused on creating the unit tests, my biggest struggle was properly handling null values in my actual method before I could test it! Out of habit I had set my variables at the top of my method but after running into null errors, I realized I needed to check for null first before going to set my variables. From there I could kill two birds with one stone optimizing for null input and strings that were empty or contained 1 character. After that, I set my variables to chop my string up and reverse it, then check longer strings against their reverse to see if they are equal.

### Update 1:
I refactored my unit tests to use IsTrue() and IsFalse() instead of .AreEqual(). I learned this is a more common approach in C# unit tests, and it makes the code easier to read.
  
I also refactored the code in my main method with suggestions from two developers on the team. The two biggest changes are just simply checking if the value of the string is null instead of using string.IsNullOrEmpty, and writing a ReverseString function. I was challenged to rewrite this functionality without using arrays or built in reverse methods and I accomplished this by iterating through the characters in the string and adding them to the front of a new string so that the returned string is the reverse of the string passed into the function.
  
## Outcome
I wrote unit tests for 100% of the test cases mentioned in the assignment and even though I was writing the tests after writing the function (not test-driven-design), they still helped me refactor my function to correct the problem I was having accepting null values. Unit tests have done it again!


    public class PalindromeChecker
    {
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

            // Null strings are not palindrome.
            if (myString == null)
            {
                return false;
            }

            // Empty and strings of one character are always palindromes.
            if (myString.Length < 2)
            {
                return true;
            }

            // Note: We can just return of the comparison here. 
            // If they are equal, the string is a palindrome, if not, the string is not. 
            return myString == ReverseString(myString);
        }

    }
