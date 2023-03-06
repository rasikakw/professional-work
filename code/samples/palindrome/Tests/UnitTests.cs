using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// Unit tests.
    /// </summary>
    [TestClass]
    public class UnitTests
    {
        Palindrome.Palindrome _palindrome;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public UnitTests()
        {
            _palindrome = new Palindrome.Palindrome();
        }

        /// <summary>
        /// Test Palindrome 1.
        /// </summary>
        [TestMethod]
        public void TestPalindrome1()
        {
            bool res = _palindrome.IsPalindrome("aa");
            Assert.IsTrue(res);
            res = _palindrome.IsPalindrome("ab");
            Assert.IsFalse(res);
            res = _palindrome.IsPalindrome("abba");
            Assert.IsTrue(res);
            res = _palindrome.IsPalindrome("bbaa");
            Assert.IsFalse(res);
            res = _palindrome.IsPalindrome("abca");
            Assert.IsFalse(res);
            res = _palindrome.IsPalindrome("aa1bb");
            Assert.IsFalse(res);
            res = _palindrome.IsPalindrome("ab1ba");
            Assert.IsTrue(res);
            res = _palindrome.IsPalindrome("11122322111");
            Assert.IsTrue(res);
        }

        /// <summary>
        /// Test Palindrome 2.
        /// </summary>
        [TestMethod]
        public void TestPalindrome2()
        {
            IList<string> res = _palindrome.Find("aab");
            Assert.AreEqual(2, res.Count);
            res = _palindrome.Find("geeks");
            Assert.AreEqual(2, res.Count);
            res = _palindrome.Find("11122322111");
            Assert.AreEqual(7, res.Count);
        }
    }
}