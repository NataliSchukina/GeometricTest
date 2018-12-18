using System;
using NUnit.Framework;


namespace GeometricTest
{
    [TestFixture]
    public class CircleTests
    {          
       
        [TestCase(1)]        [TestCase(2)]
        [TestCase(3)]        [TestCase(4)]
        [TestCase(5)]        [TestCase(6)]
        [TestCase(7)]        [TestCase(8)]
        [TestCase(9)]        [TestCase(10)]
        [TestCase(11)]       [TestCase(12)]
        [TestCase(13)]       [TestCase(14)]
        [TestCase(15)]       [TestCase(16)]
        [TestCase(17)]       [TestCase(18)]
        [TestCase(19)]       [TestCase(20)]
        
                
        public void TestGetAreaCirclePositive(int r)
        {
                double delta = 0.05;
                
            {
                double expectedsq = Math.PI * r * r;
                GeometricFigures.Circle circle = new GeometricFigures.Circle(r);
                double actualsq = circle.getAreaCircle();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", r);
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
        public void TestGetLenghtCirclePositive(int r)
        {
            double delta = 0.05;
            
            {
                double expectedln = Math.PI * 2 * r;
                GeometricFigures.Circle circle = new GeometricFigures.Circle(r);
                double actualln = circle.getLengthCircle();
                Assert.AreEqual(expectedln, actualln, delta, "It doesn't work with argument = {0}", r);
            }
        }
         
        [TestCase (0)]
        [TestCase(-10)]
        public void TestGetAreaCircleNegative(int r)
        {
            Assert.Throws<Exception>(() =>
            {
                GeometricFigures.Circle obj = new GeometricFigures.Circle(r);
                var area = obj.getAreaCircle();
            }, "Exception is expected");
        }


          }
}
