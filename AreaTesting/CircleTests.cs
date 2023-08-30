using AreaOfFigures.Figures;
using FigureServices.Models;

namespace SquareCalculator.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-100)]

        public void Constructor_InvalidRadius(double radius) 
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2.5, Math.PI * 6.25)]
        [InlineData(5, Math.PI * 25)]

        public void CalculateArea_ShouldReturnCorrectArea(double radius, double expectedArea)
        {
            var circle = new Circle(radius);
            double actualArea = circle.CalculateArea();

            Assert.Equal(expectedArea, actualArea);
        }
    }
}
