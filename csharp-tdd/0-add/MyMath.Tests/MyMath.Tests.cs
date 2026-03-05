using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            int result = Operations.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            int result = Operations.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int result = Operations.Add(5, -3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            int result = Operations.Add(5, 0);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            int result = Operations.Add(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}