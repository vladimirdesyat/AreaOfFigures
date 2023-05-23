using AreaOfFigures.Figures;

namespace AreaOfFigures
{
    public abstract class Figure
    {
        /// <summary>
        /// 2D array with X,Y coordinates
        /// </summary>
        public double[,]? XY { get; set; }
        /// <summary>
        /// Figure area
        /// </summary>
        public double Area { get; private set; }
        public Figure(double[,]? xy)
        {
            _ = xy == null ?
                throw new NullReferenceException("Invalid data: array XY is null.")
                :
                xy?.Length <= 2 || xy?.Length % 2 != 0 ?
                throw new ArgumentException("Invalid data: Coordinate array XY length less than two, or divided by two with a remainder.") 
                :
                XY = xy;
        }
    }
}
