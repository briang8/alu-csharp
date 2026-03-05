using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsPalindrome_SimpleWord_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("racecar");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_CaseSensitive_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("Racecar");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_Level_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("level");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("");
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            bool result = Str.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome(null);
            Assert.IsTrue(result);
        }
    }
}