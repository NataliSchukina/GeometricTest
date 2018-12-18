using System;
using NUnit.Framework;

namespace GeometricTest
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 5, 7)]
      
        public void TestGetAreaTrianglePositive(int a, int b, int c)
        {
            double delta = 0.05;
              
            {
                double p = (double)(a + b + c) / 2;
                double expectedsq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                GeometricFigures.Triangle square = new GeometricFigures.Triangle(a, b, c);
                double actualsq = square.getAreaTriangle();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with arguments ={0},{1},{2}", a, b, c);
            }
        }
        [TestCase(1, 1, 1)]
        [TestCase(1, 5, 7)]
      
        public void TestGetLengthTrianglePositive(int a, int b, int c)
        {
            double delta = 0.05;

               {
                double expectedsq = a + b + c;
                GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(a, b, c);
                double actualsq = triangle.getLengthTriangle();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with arguments = {0},{1},{2}", a, b, c);
            }

        }
        [TestCase(1, 1, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 10, 1)]
        [TestCase(1, 10, 20)]

        public void TestAreaTriangleNegative(int a, int b, int c)
        {
            Assert.Throws<Exception>(() =>
            {
                var triangle = new GeometricFigures.Triangle(a,b,c);
                var actualsq = triangle.getAreaTriangle();
            }, "Exception is expected");
        }
    }
}
            
        
    
