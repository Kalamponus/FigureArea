using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaTest
{
    [TestClass]
    public class FigureAreaTests
    {
        //Тестирование нахождения площади треугольника
        [TestMethod]
        public void TriangleAreaRightTriangle()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(6, 8, 10);
            Assert.AreEqual(24, triangle.Area());
        }        
        [TestMethod]
        public void TriangleAreaEqualSides()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(8, 8, 8);
            Assert.AreNotEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaNormal()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(6, 5, 10);
            Assert.AreNotEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaNegativeSides()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(-8, -6, -10);
            Assert.AreEqual(-1, triangle.Area());
        }
        [TestMethod]
        public void TriangleAreaCantExist()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(2, 6, 10);
            Assert.AreEqual(-1, triangle.Area());
        }
        //Тестирование нахождения площади треугольника по упрощённой схеме
        [TestMethod]
        public void TriangleSimpleAreaRightTriangle()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(6, 8, 10);
            Assert.AreEqual(24, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaEqualSides()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(8, 8, 8);
            Assert.AreNotEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaNormal()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(6, 5, 10);
            Assert.AreNotEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaNegativeSides()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(-8, -6, -10);
            Assert.AreEqual(-1, triangle.AreaSimple());
        }
        [TestMethod]
        public void TriangleSimpleAreaCantExist()
        {
            FigureAreaLib.Triangle triangle = new FigureAreaLib.Triangle(2, 6, 10);
            Assert.AreEqual(-1, triangle.AreaSimple());
        }
        //Тестирование нахождения площади круга
        [TestMethod]
        public void CircleNormal()
        {
            FigureAreaLib.Circle circle = new FigureAreaLib.Circle(8);
            Assert.AreNotEqual(-1, circle.Area());
        }
        public void CircleNegativeNumber()
        {
            FigureAreaLib.Circle circle = new FigureAreaLib.Circle(-8);
            Assert.AreEqual(-1, circle.Area());
        }
    }
}
