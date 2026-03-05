using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            int result = Str.UniqueChar("abcd");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_MiddleCharUnique_ReturnsCorrectIndex()
        {
            int result = Str.UniqueChar("aabcd");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void UniqueChar_NoUniqueChars_ReturnsMinusOne()
        {
            int result = Str.UniqueChar("aabbcc");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            int result = Str.UniqueChar("");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_NullString_ReturnsMinusOne()
        {
            int result = Str.UniqueChar(null);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            int result = Str.UniqueChar("a");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_LastCharUnique_ReturnsCorrectIndex()
        {
            int result = Str.UniqueChar("aabccd");
            Assert.AreEqual(5, result);
        }
    }
}