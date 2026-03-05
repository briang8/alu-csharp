using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            int result = Str.CamelCase("hello");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            int result = Str.CamelCase("helloWorld");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("thisIsATestString");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            int result = Str.CamelCase("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            int result = Str.CamelCase(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_StartWithCapital_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("HelloWorld");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_AllCapitals_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("ABC");
            Assert.AreEqual(3, result);
        }
    }
}