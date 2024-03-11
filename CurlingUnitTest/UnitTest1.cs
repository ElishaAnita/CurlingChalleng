using CurlingChalleng.Classes;
using CurlingChalleng.Helper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;

namespace CurlingUnitTest
{
    [TestFixture]
    public class Tests
    {
        //private GenerateXYCordinateValues _generateXYCordinateValues;
        [SetUp]
        public void Setup()
        {


        }
        [Test]
        public void Mock_GetY_Coordinate_Wrapper()
        {
            // Arrange
            var d = new List<Disk>();
            List<int> xc = new List<int>();
            xc.Add(5);
            xc.Add(5);
            xc.Add(6);
            xc.Add(8);
            xc.Add(3);
            xc.Add(12);
            var mock = new Mock<IWrapper>();

            mock.Setup(x => x.GetY_Coordinate(xc, 2, "Circle")).Returns(d);
            var result = new GenerateXYCordinateValues(mock.Object);
            // Act
            var actual = result.GetType().Name;
            // Assert
            NUnit.Framework.Assert.IsFalse(actual.Contains("bbb"));
           
        }
        [Test]
        public void Mock_X_Coordinate_Wrapper()
        {
         
            var list = new List<int> { 5,6,2,5,9,3 };
            var expected = list;
            var mock = new Mock<IWrapper>();
            mock.Setup(rand => rand.GenerateX_Coordinate(list.Count)).Returns(() => list); 
            var subject = new GenerateXYCordinateValues(mock.Object);
            //Assert
            NUnit.Framework.Assert.AreEqual(expected.Count,6);

        }
        [Test]
        public void TestSqareArea()
        {
            var result = new Square(2.0,5,2.0);
            var area = result.GetArea();

            NUnit.Framework.Assert.That(4, Is.EqualTo(area));


        }

        [Test]
        public void TestCircleArea()
        {
            var result = new Circle(2.0, 5, 2.0);
            var area = result.GetArea();

            NUnit.Framework.Assert.That(5.8, Is.EqualTo(area));


        }
        [Test]
        public void TestDisKType()
        {
            var result = new Circle();
            var c = result.GetType();
            NUnit.Framework.Assert.IsTrue(c.Name.Equals("Circle"));


        }
        [Test]
        public void TestTrianglePerimeter()
        {
            var result = new Triangle(3, 3, 5, 5, 9, 2);
            var perimeter = result.GetPerimeter();
            NUnit.Framework.Assert.AreEqual(perimeter, 11);
           
        }

    }
}