using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

namespace AreaOfFigures.Figures
{
    public sealed class Polygon : Figure
    {
        public Polygon(double[,]? xy) : base(xy)
        {            
        }
        /// <summary>
        /// The area of a simple polygon is calculated by the coordinates (vertices of the polygon) 
        /// of the rectangular coordinate system X, Y using the Gauss area formula
        /// </summary>
        /// <exc>
        public double AreaCalc()
        {
            var temp = 0.0;
            var j = XY.Length / 2 - 1;
            for (var i = 0; i < XY.Length / 2; i++)
            {
                temp += (XY[0, j] + XY[0, i]) * (XY[1, j] - XY[1, i]);
                j = i;
            }
            temp = Math.Abs(temp / 2.0);
            return temp;
        }
        /// <summary>
        /// Checking a right triangle is carried out according to the Heron formula and the Pythagorean theorem
        /// </summary>
        public bool RightTriangleCheck()
        {
            var firstSide = Math.Pow(Math.Abs(XY[0, 1] - XY[0, 0]), 2) + Math.Pow(Math.Abs(XY[1, 1] - XY[1, 0]), 2);
            var secondSide = Math.Pow(Math.Abs(XY[0, 2] - XY[0, 1]), 2) + Math.Pow(Math.Abs(XY[1, 2] - XY[1, 1]), 2);
            var thirdSide = Math.Pow(Math.Abs(XY[0, 2] - XY[0, 0]), 2) + Math.Pow(Math.Abs(XY[1, 2] - XY[1, 0]), 2);
            var sides = new[] { firstSide, secondSide, thirdSide };
            Array.Sort(sides);
            return sides[0] + sides[1] == sides[2] ?
            true
            :
            false;
        }
    }
}
