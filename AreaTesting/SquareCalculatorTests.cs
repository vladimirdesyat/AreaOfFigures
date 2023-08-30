using FigureServices.Interfaces;
using FigureServices.Models;
using FigureServices.Services;

namespace SquareCalculator.Tests
{
    public class SquareCalculatorTests
    {
        [Fact]
        public void CalculateArea_ArgumentNullExceptionExpected()
        {
            Assert.Throws<ArgumentNullException>(() => SquareCalculator.CalculateArea(null));
        }

        [Theory]
        [InlineData(1,Math.PI)]
        [InlineData(2.5,Math.PI * 6.25)]
        [InlineData(5, Math.PI * 25)]

        public void CalculateArea_ShouldReturnCorrectAreaForCircle(double radius, double expectedArea)
        {
            ICalculateArea figure = new Circle(radius);

            double actualArea = SquareCalculator.CalculateArea(figure);

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }

        [Theory]
        [InlineData(5,5,5,10.83)]
        [InlineData(3,4,,6,5.33)]
        [InlineData(2,2,3,1.98)]
        [InlineData(3,4,5,5.56)]

        public void CalculateArea_ShouldReturnCorrectAreaForTriangle(double sideA, double sideB, double sideC, double expectedArea)
        {
            ICalculateArea figure = new Triangle(sideA,sideB,sideC);

            double actualArea = SquareCalculator.CalculateArea(figure);

            Assert.Equal(expectedArea, actualArea, precision: 2);
        }
    }
}
