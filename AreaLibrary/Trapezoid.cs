using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Trapezoid : IFigure
    {
        public double sideA;
        public double sideB;
        public double height;

        public Trapezoid(double sideA, double sideB, double height)
        {
            if (sideA <= 0 || sideB <= 0 || height <= 0)
                throw new ArgumentException("Sides and height can not be less than 0 or equal to 0");

            this.sideA = sideA;
            this.sideB = sideB;
            this.height = height;
        }
        public double GetArea()
        {
            double area = (sideA + sideB) / 2 * height;

            return area;
        }
    }
}
