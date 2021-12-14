using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void GetAreaCircleTest()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            var result = circle.Area();

            //Assert
            Assert.AreEqual(314.15926535897931, result);
        }
        [TestMethod()]
        public void GetAreaCircleNegativeValueTest()
        {
           
            Assert.ThrowsException<ArgumentException>(() => new Circle(-10));
        }

        [TestMethod()]
        public void GetAreaTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);

            //Act
            var result = triangle.Area();

            //Assert
            Assert.AreEqual(6, result);
        }
        [TestMethod()]
        public void TriangleNegativeSidesTest()
        {

            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, 0, 8));

        }
        [TestMethod()]
        public void NineFor4x4SquareTest()
        {
            var square = new Square(4);

            var result = square.Area();

            Assert.AreEqual(16, result);

        }

        [TestMethod()]
        public void ListOfShapesTest()
        {
            var shapes = new List<Shape> { new Triangle(3, 4, 5), new Circle(10), new Square(4) };

            var areas = shapes.Select(t => t.Area()).ToList();

            Assert.AreEqual(6, areas[0]);
            Assert.AreEqual(314.15926535897931, areas[1]);
            Assert.AreEqual(16, areas[2]);
        }

        [TestMethod()]
        public void IsNotTriangleTest()
        {
            Assert.ThrowsException<Exception>(()=> new Triangle(11, 3, 4));
        }
    }
}