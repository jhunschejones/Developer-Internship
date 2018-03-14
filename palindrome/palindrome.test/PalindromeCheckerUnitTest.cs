using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;


namespace Palindrome.test
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
            Assert.AreEqual(true, a);
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
            Assert.AreEqual(false, a);
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
            Assert.AreEqual(true, a);
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
            Assert.AreEqual(true, a);
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
            Assert.AreEqual(false, a);
        }

    }
}