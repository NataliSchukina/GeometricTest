using System;
using NUnit.Framework;

namespace GeometricTest
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(1)]        [TestCase(2)]
        [TestCase(3)]        [TestCase(4)]
        [TestCase(5)]        [TestCase(6)]
        [TestCase(7)]        [TestCase(8)]
        [TestCase(9)]        [TestCase(10)]
        [TestCase(11)]        [TestCase(12)]
        [TestCase(13)]        [TestCase(14)]
        [TestCase(15)]        [TestCase(16)]
        [TestCase(17)]        [TestCase(18)]
        [TestCase(19)]        [TestCase(20)]

        public void TestGetAreaSquarePositive(int a)
        {
            double delta = 0.05;
            
            {
                double expectedsq = a * a;
                GeometricFigures.Square square = new GeometricFigures.Square(a);
                double actualsq = square.getAreaSquare();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", a);

            }
        }

        [TestCase(1)]        [TestCase(2)]
        [TestCase(3)]        [TestCase(4)]
        [TestCase(5)]        [TestCase(6)]
        [TestCase(7)]        [TestCase(8)]
        [TestCase(9)]        [TestCase(10)]
        [TestCase(11)]        [TestCase(12)]
        [TestCase(13)]        [TestCase(14)]
        [TestCase(15)]        [TestCase(16)]
        [TestCase(17)]        [TestCase(18)]
        [TestCase(19)]        [TestCase(20)]
        public void TestGetlengthSquarePositive(int a)
        {
            double delta = 0.05;
         
            {
                double expectedsq = 4 * a;
                GeometricFigures.Square square = new GeometricFigures.Square(a);
                double actualsq = square.getLengthSquare();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", a);

            }
        }
    }
}
