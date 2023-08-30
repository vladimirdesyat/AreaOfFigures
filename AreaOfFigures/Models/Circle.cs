using FigureServices.Interfaces;

namespace AreaOfFigures.Figures
{
    public class Circle : ICalculateArea
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be greater that zero.", nameof(radius));
            }

            _radius = radius;
        }
       
        public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);
    }
}
