using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLibrary;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result, String.Format("Expected for '{0}': true; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        [DataRow("alphabet")]
        [DataRow("error")]
        [DataRow("αυτοκινητοβιομηχανία")]
        [DataRow(".")]
        public void TestDoesNotStartWithUpper(string someString)
        {
            // Tests that we expect to return false.
                bool result = someString.StartsWithUpper();
                Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual: {1}", someString, result));
        }

        [TestMethod]
        [DataRow("string.Empty")]
        [DataRow(null)]
        public void DirectCallWithNullOrEmpty(string someString)
        {
            // Tests that we expect to return false.
            bool result = StringLibrary.StringLibrary.StartsWithUpper(someString);
            Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual: {1}", someString == null ? "<null>" : someString, result));
        }
    }
}
