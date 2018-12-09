using System;
using NUnit.Framework;


namespace GeometricTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestAreaCircle1()
        {
            GeometricFigures.Circle obj1 = new GeometricFigures.Circle(0);
            Assert.AreEqual(0, obj1.getAreaCircle());
        }


        [Test]
        public void TestAreaCircle()
        {
            Assert.Throws<Exception>(() => {
                GeometricFigures.Circle obj = new GeometricFigures.Circle(-10);
                var area = obj.getAreaCircle();
            }, "Должно быть Exception, а его нет ");
        }

        [Test]
        public void TestAreaCircle2()
        {
            const double delta = 0.05;
            GeometricFigures.Circle obj2 = new GeometricFigures.Circle(20);
            Assert.AreEqual(1256.63, obj2.getAreaCircle(),delta);
        }

        [Test]
        public void TestLenghtCircle1()
        {
            GeometricFigures.Circle obj3 = new GeometricFigures.Circle(0);
            Assert.AreEqual(0, obj3.getLengthCircle());
           
        }

        [Test]
        public void TestLenghtCircle()
        {
            Assert.Throws<Exception>(() => {
                GeometricFigures.Circle obj = new GeometricFigures.Circle(0);
                var length = obj.getLengthCircle();
            }, "Должно быть Exception, а его нет ");
        }

        [Test]
        public void TestLenghtCircle2()
        {
            GeometricFigures.Circle obj4 = new GeometricFigures.Circle(20);
            Assert.AreEqual(125.66,Math.Round(obj4.getLengthCircle(),2));
            
        }

         [Test]
         public void TestAreaSquare1()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(0);
            Assert.AreEqual(0, square.getAreaSquare());
        }

        [Test]
        public void TestAreaSquare2()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(20);
            Assert.AreEqual(400, Math.Round(square.getAreaSquare(),2));
        }

        [Test]
        public void TestlengthSquare1()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(0);
            Assert.AreEqual(0,square.getLengthSquare());
        }

        [Test]
        public void TestlengthSquare2()
        {
            GeometricFigures.Square square = new GeometricFigures.Square(20);
            Assert.AreEqual(80, Math.Round(square.getLengthSquare(), 2));
        }

        [Test]
        public void TestAreaTriangle1()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0,0,0);
            Assert.AreEqual(0, triangle.getAreaTriangle());
        }

        [Test]
        public void TestAreaTriangle()
        {
            Assert.Throws<Exception>(() => {
                GeometricFigures.Triangle obj = new GeometricFigures.Triangle(0,0,0);
                var area = obj.getAreaTriangle();
            }, "Должно быть Exception, а его нет ");
        }
        [Test]
        public void TestAreaTriangle2()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0,0,20);
            Assert.IsNaN(triangle.getAreaTriangle());
        }
        [Test]
        public void TestAreaTriangle3()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0, 20, 20);
            Assert.AreEqual(0, triangle.getAreaTriangle());
        }

        [Test]
        public void TestAreaTriangle4()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(20,20,20);
            Assert.AreEqual(173.21, Math.Round(triangle.getAreaTriangle(), 2));
        }

        [Test]
        public void TestLengthTriangle1()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0, 0, 0);
            Assert.AreEqual(0, triangle.getLengthTriangle());
        }

        [Test]
        public void TestLengthTriangle2()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0, 0, 20);
            Assert.AreEqual(20,triangle.getLengthTriangle());
        }
        [Test]
        public void TestLengthTriangle3()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(0, 20, 20);
            Assert.AreEqual(40, triangle.getLengthTriangle());
        }
        
        [Test]
        public void TestLengthTriangle4()
        {
            GeometricFigures.Triangle triangle = new GeometricFigures.Triangle(20, 20, 20);
            Assert.AreEqual(60, Math.Round(triangle.getLengthTriangle(), 2));
        }


    }


}
