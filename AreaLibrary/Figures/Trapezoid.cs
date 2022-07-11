using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Trapezoid : IFigure
    {
        public double sideA;
        public double sideB;
        public double sideC;
        public double sideD;

        public Trapezoid(double sideA, double sideB, double sideC, double sideD)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0 || sideD <= 0)
                throw new ArgumentException("Sides and height can not be less than 0 or equal to 0");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }
        public double GetArea()
        {
            double area = ((sideA + sideB) / 2) * Math.Sqrt(Math.Pow(sideC, 2) - Math.Pow((Math.Pow((sideA - sideB), 2) + Math.Pow(sideC, 2) - Math.Pow(sideD, 2)) / (2 * (sideA - sideB)), 2));

            Console.WriteLine("Area of this trapezoid is " + area);
            return area;
        }
    }
}
