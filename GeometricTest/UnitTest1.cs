using System;
using NUnit.Framework;


namespace GeometricTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestGetAreaCirclePositive()
        {
            double delta = 0.05;
            for (int r = 0; r < 21; r++)

            {
                double expectedsq = Math.PI * r * r;
                GeometricFigures.Circle circle = new GeometricFigures.Circle(r);
                double actualsq = circle.getAreaCircle();
                Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", r);
            }
        }

        [Test]
        public void TestGetLenghtCirclePositive()
        {
            double delta = 0.05;
            for (int r = 0; r < 21; r++)

            {
                double expectedln = Math.PI * 2 * r;
                GeometricFigures.Circle circle = new GeometricFigures.Circle(r);
                double actualln = circle.getLengthCircle();
                Assert.AreEqual(expectedln, actualln, delta, "It doesn't work with argument = {0}", r);
            }
        }


        [Test]
        public void TestGetAreaSquarePositive()
        {
            double delta = 0.05;
            for (int a = 0; a < 21; a++)

            {
                
                    double expectedsq = a * a;
                    GeometricFigures.Square square = new GeometricFigures.Square(a);
                    double actualsq = square.getAreaSquare();
                    Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", a);
                
            }
        }

        [Test]
        public void TestGetlengthSquarePositive()
        {
            double delta = 0.05;
            for (int a = 0; a < 21; a++)

            {
               
                    double expectedsq = 4 * a;
                    GeometricFigures.Square square = new GeometricFigures.Square(a);
                    double actualsq = square.getLengthSquare();
                    Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with argument = {0}", a);
                
            }
        }


        [Test]
        public void TestGetAreaTrianglePositive()
        {
            double delta = 0.05;
            for (int a = 1; a < 21; a++)
            {
                for (int b = 1; b < 21; b++)
                {
                    for (int c = 1; c < 21; c++)
                    {
                        if (((a < b + c) & (a > b - c)) & ((b < a + c) & (b > a - c)) & ((c < a + b) & (c > a - b)))
                        {
                            double p = (double)(a + b + c) / 2;
                            double expectedsq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                            GeometricFigures.Triangle square = new GeometricFigures.Triangle(a, b, c);
                            double actualsq = square.getAreaTriangle();
                            Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with arguments ={0},{1},{2}", a, b, c);
                        }
                    }
                }
            }
        }

        [Test]
        public void TestGetLengthTrianglePositive()
        {
            double delta = 0.05;
            for (int a = 1; a < 21; a++)
            {
                for (int b = 1; b < 21; b++)

                {
                    for (int c = 1; c < 21; c++)

                    {
                        if (((a < b + c) & (a > b - c)) & ((b < a + c) & (b > a - c)) & ((c < a + b) & (c > a - b)))

                        {
                            double expectedsq = a + b + c;
                            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(a, b, c);
                            double actualsq = triangle.getLengthTriangle();
                            Assert.AreEqual(expectedsq, actualsq, delta, "It doesn't work with arguments = {0},{1},{2}", a, b, c);
                        }
                    }
                }
            }
        }


        [Test]
        public void TestGetAreaCircleNegative()
        {
            Assert.Throws<Exception>(() =>
            {
                GeometricFigures.Circle obj = new GeometricFigures.Circle(-10);
                var area = obj.getAreaCircle();
            }, "Exception is expected");
        }



        [Test]
        public void TestGetAreaTriangleNegative()
        {
            Assert.Throws<Exception>(() =>
            {
                var triangle = new GeometricFigures.Triangle(-1, 1, 10);
                var actualsq = triangle.getAreaTriangle();
            },"Exception is expected");
        }

       
    }
}
