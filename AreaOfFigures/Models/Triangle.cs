using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices.Interfaces;

namespace FigureServices.Models
{
    public class Triangle : ICalculateArea
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid triangle sides.");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        private static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public double CalculateArea()
        {
            double semiperimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
        }

        public bool IsRightTriangle()
        {
            List<double> sortedSides = new() {_sideA, _sideB, _sideC };
            sortedSides.Sort();

            return Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2);
        }
    }
}
