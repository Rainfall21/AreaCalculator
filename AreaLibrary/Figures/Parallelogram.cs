using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Parallelogram : IFigure
    {
        public double side;
        public double height;

        public Parallelogram(double side, double height)
        {
            if (side <= 0 || height <= 0)
                throw new ArgumentException("Sides and height can not be equal to 0 or less than 0");

            this.side = side;
            this.height = height;
        }

        public double GetArea()
        {
            double area = side * height;
            Console.WriteLine("Area of this parallelogram is " + area);

            return area;
        }
    }
}
