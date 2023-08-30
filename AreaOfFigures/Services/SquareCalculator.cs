using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureServices.Interfaces;

namespace FigureServices.Services
{
    public static class SquareCalculator
    {
        public static double CalculateArea(ICalculateArea figure)
        {
            if (figure is null) 
                throw new ArgumentNullException("Figure cannot be null");
            
            return figure.CalculateArea();
        }
        

    }
}
