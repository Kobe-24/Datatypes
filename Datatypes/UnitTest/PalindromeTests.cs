using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Datatypes;

namespace UnitTest
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void IsPalindromeOne()
        {
            //Arrange
            var checker = new PalindromeCheck();
            var word = "ABBA";
            //Action

            var isPalindrome = checker.IsPalindrome(word);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeTwo()
        {
            //Arrange
            var checker = new PalindromeCheck();
            var word = "ABEBA";
            //Action

            var isPalindrome = checker.IsPalindrome(word);

            //Assert
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void IsPalindromeThree()
        {
            //Arrange
            var checker = new PalindromeCheck();
            var word = "A";
            //Action

            var isPalindrome = checker.IsPalindrome(word);

            //Assert
            Assert.IsFalse(isPalindrome);
        }
    }
}
