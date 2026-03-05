using System.Collections.Generic;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Max_ValidList_ReturnsMaximumValue()
        {
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            List<int> nums = new List<int> { 42 };
            int result = Operations.Max(nums);
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMaximumValue()
        {
            List<int> nums = new List<int> { -5, -1, -10, -3 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }
    }
}