using FigureServices.Models;

namespace SquareCalculator.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 1, 2)]
        [InlineData(1, 0, 2)]
        [InlineData(1, 2, 0)]
        [InlineData(-1, 2, 3)]
        [InlineData(1, -2, 3)]
        [InlineData(1, 2, -3)]

        public void Constructor_InvalidSides_ArgumentExceptionExpected(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(6, 8, 10, true)]
        [InlineData(7, 24, 25, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(9, 40, 41, true)]
        [InlineData(1, 1, 1, false)]
        [InlineData(5, 5, 5, false)]
        [InlineData(3, 4, 6, false)]
        [InlineData(2, 2, 3, false)]
        [InlineData(3, 4, 4, false)]
        public void IsRightTriangle_ShouldReturnCorrectResult(double sideA, double sideB, double sideC, bool expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            bool actualResult = triangle.IsRightTriangle();

            Assert.Equal(expected, actualResult);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 12, 13, 30)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(7, 24, 25, 84)]
        [InlineData(8, 15, 17, 60)]
        [InlineData(9, 40, 41, 180)]
        [InlineData(1, 1, 1, 0.43)]
        [InlineData(5, 5, 5, 10.83)]
        [InlineData(3, 4, 6, 5.33)]
        [InlineData(2, 2, 3, 1.98)]
        [InlineData(3, 4, 4, 5.56)]
        public void CalculateArea_ShouldReturnCorrectArea(double sideA, double sideB, double sideC, double expectedArea)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            double actualArea = triangle.CalculateArea();

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }
    }
