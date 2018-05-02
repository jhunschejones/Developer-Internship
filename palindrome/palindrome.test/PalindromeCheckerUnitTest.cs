using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Test
{
    [TestClass]
    public class PalindromeCheckerUnitTest
    {
        [TestMethod]
        public void IsPalindromeEmptyStringTest()
        {
            // Arrange
            string myString = "";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            // The following is fine: Assert.AreEqual(true, a); but the below is more common.
            // TODO: Fix the rest of the tests to use IsTrue or IsFalse;
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void IsPalindromeOneCharacterTest()
        {
            // Arrange
            string myString = "a";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void IsPalindromeTwoCharacterTest()
        {
            // Arrange
            string myString = "ab";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsFalse(a);
        }

        [TestMethod]
        public void IsPalindromeFourCharacterTest()
        {
            // Arrange
            string myString = "abba";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void IsPalindromeMultiCharacterTest()
        {
            // Arrange
            string myString = "tattarrattat";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsTrue(a);
        }

        [TestMethod]
        public void IsPalindromeMultiCharacterTest2()
        {
            // Arrange

            // Note, it's so close to a palindrome, but not quite. 
            string myString = "tattarsattat";
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsFalse(a);
        }


        [TestMethod]
        public void IsPalindromeNullTest()
        {
            // Arrange
            string myString = null;
            PalindromeChecker p = new PalindromeChecker();

            // Act
            bool a = p.IsPalindrome(myString);

            // Assert
            Assert.IsFalse(a);
        }

    }
}
