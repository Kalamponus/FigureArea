using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FigureAreaLib;
namespace FigureAreaTest
{
    [TestClass]
    public class FigureAreaTests
    {
        //Тестирование нахождения площади треугольника
        [TestMethod]
        public void TriangleAreaRightTriangle()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Assert.AreEqual(24, triangle.Area());
        }        
        [TestMethod]
        public void TriangleAreaEqualSides()
        {
            Triangle triangle = new Triangle(8, 8, 8);
            Assert.AreNotEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaNormal()
        {
            Triangle triangle = new Triangle(6, 5, 10);
            Assert.AreNotEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaNegativeSides()
        {
            Triangle triangle = new Triangle(-8, -6, -10);
            Assert.AreEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaCantExist()
        {
            Triangle triangle = new Triangle(2, 6, 10);
            Assert.AreEqual(-1, triangle.Area());
        }
        //Тестирование нахождения площади треугольника по упрощённой схеме
        [TestMethod]
        public void TriangleSimpleAreaRightTriangle()
        {
            Triangle triangle = new Triangle(6, 8, 10);
            Assert.AreEqual(24, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaEqualSides()
        {
            Triangle triangle = new Triangle(8, 8, 8);
            Assert.AreNotEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaNormal()
        {
            Triangle triangle = new Triangle(6, 5, 10);
            Assert.AreNotEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaNegativeSides()
        {
            Triangle triangle = new Triangle(-8, -6, -10);
            Assert.AreEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaCantExist()
        {
            Triangle triangle = new Triangle(2, 6, 10);
            Assert.AreEqual(-1, triangle.AreaSimple());
        }
        //Тестирование нахождения площади круга
        [TestMethod]
        public void CircleNormal()
        {
            Circle circle = new Circle(8);
            Assert.AreNotEqual(-1, circle.Area());
        }
        public void CircleNegativeNumber()
        {
            Circle circle = new Circle(-8);
            Assert.AreEqual(-1, circle.Area());
        }
    }
}
