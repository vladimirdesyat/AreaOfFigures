namespace AreaOfFigures.Figures
{
    public sealed class Circle : Figure
    {
        public Circle(double[,]? xy) : base(xy)
        {            
        }
        /// <summary>
        /// Getting the radius length from coordinates X,Y
        /// The area of a circle according to the formula pi * radius squared
        /// </summary>
        public double AreaCalc()
        {
            return Math.PI * Math.Pow(Math.Abs(XY[0, 1] - XY[0, 0]) + Math.Abs(XY[1, 1] - XY[1, 0]), 2);
        }
    }
}
