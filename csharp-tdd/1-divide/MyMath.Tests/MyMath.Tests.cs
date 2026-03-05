using System;
using System.IO;
using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Divide_ValidMatrix_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = { { 5, 10 }, { 15, 20 } };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_ByZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] result = Matrix.Divide(matrix, 0);
                string output = sw.ToString().Trim();

                Assert.IsNull(result);
                Assert.AreEqual("Num cannot be 0", output);
            }
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_SingleElement_ReturnsCorrectResult()
        {
            int[,] matrix = { { 12 } };
            int[,] result = Matrix.Divide(matrix, 3);
            int[,] expected = { { 4 } };

            Assert.AreEqual(expected, result);
        }
    }
}