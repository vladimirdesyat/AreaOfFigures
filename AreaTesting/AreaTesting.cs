using System.Drawing;
using AreaOfFigures.Figures;

namespace AreaTesting
{
    [TestClass]
    public class AreaTests
    {
        /// <summary>
        /// Checking a circle area
        /// </summary>
        [TestMethod]
        public void CircleCheckArea()
        {
            double[,] xy = { { 2, 1 }, { 1, 3 } };
            double expected = 28.274333882308138;
            var circle = new Circle(xy);
            Assert.AreEqual(expected, circle.AreaCalc());
        }
        /// <summary>
        /// Checking a circle area
        /// </summary>
        [TestMethod]
        public void CircleCheckAreaNegative()
        {
            double[,] xy = { { 2, -1 }, { 1, 3 } };
            double expected = 78.53981633974483;
            var circle = new Circle(xy);
            Assert.AreEqual(expected, circle.AreaCalc());
        }
        /// <summary>
        /// Checking a triangle area
        /// </summary>
        [TestMethod]
        public void TriangleCheckArea()
        {
            double[,] xy = { { 2, 1, 7 }, { 1, 3, 6 } };
            var triangle = new Polygon(xy);
            double expected = 7.5;
            Assert.AreEqual(expected, triangle.AreaCalc());
        }
        /// <summary>
        /// Checking a triangle area with negative point
        /// </summary>
        [TestMethod]
        public void TriangleCheckAreaNegative()
        {
            double[,] xy = { { 0, -2, 4 }, { 1, 3, 7 } };
            var triangle = new Polygon(xy);
            double expected = 10;
            Assert.AreEqual(expected, triangle.AreaCalc());
        }
        /// <summary>
        /// Checking a right triangle
        /// </summary>
        [TestMethod]
        public void RightTriangleCheck()
        {
            double[,] xy = { { 1, 1, 4 }, { 1, 4, 1 } };
            var triangle = new Polygon(xy);
            bool expected = true;
            Assert.AreEqual(expected, triangle.RightTriangleCheck());
        }
        /// <summary>
        /// Checking a non right triangle
        /// </summary>
        [TestMethod]
        public void NonRightTriangleCheck()
        {
            double[,] xy = { { 1, 3, 4 }, { 4, 2, 2 } };
            var triangle = new Polygon(xy);
            bool expected = false;
            Assert.AreEqual(expected, triangle.RightTriangleCheck());
        }
        /// <summary>
        /// Checking rectangle area
        /// </summary>
        [TestMethod]
        public void RectangleCheckArea()
        {
            double[,] xy = { { 1, 1, 4, 4 }, { 4, 1, 1, 4 } };
            double expected = 9;
            var rectangle = new Polygon(xy);
            Assert.AreEqual(expected, rectangle.AreaCalc());
        }
        /// <summary>
        /// Checking a point
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Invalid data: Coordinate array XY length less than 2, or divided by two with a remainder.")]
        public void PointCheck()
        {
            double[,] xy = { { 1 },{ 4 } };
            _ = new Polygon(xy);
            // Assert.ThrowsException<ArgumentException>(() => point.PolygonAreaCalc());
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException),
        "Invalid data: array XY is null.")]
        public void NullCheck()
        {
            double[,]? xy = null;
            _ = new Polygon(xy);
        }
    }
}
