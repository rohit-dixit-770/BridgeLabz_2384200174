using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils stringUtils;
        [SetUp]
        public void Setup()
        {
            stringUtils = new StringUtils();
        }
        [Test]
        public void Reverse_ShouldReturnReversedString()
        {
            Assert.AreEqual("dcba", stringUtils.Reverse("abcd"));
            Assert.AreEqual("", stringUtils.Reverse(""));
            Assert.AreEqual(null, stringUtils.Reverse(null));
        }

        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindromes()
        {
            Assert.IsTrue(stringUtils.IsPalindrome("madam"));
            Assert.IsTrue(stringUtils.IsPalindrome("racecar"));
            Assert.IsTrue(stringUtils.IsPalindrome("Madam")); // Case insensitive
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindromes()
        {
            Assert.IsFalse(stringUtils.IsPalindrome("hello"));
            Assert.IsFalse(stringUtils.IsPalindrome("world"));
        }

        [Test]
        public void ToUpperCase_ShouldConvertToUpperCase()
        {
            Assert.AreEqual("HELLO", stringUtils.ToUpperCase("hello"));
            Assert.AreEqual("TEST", stringUtils.ToUpperCase("test"));
            Assert.AreEqual("", stringUtils.ToUpperCase(""));
            Assert.AreEqual(null, stringUtils.ToUpperCase(null));
        }
    }
}
