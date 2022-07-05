using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Rhombus : IFigure
    {
        public double side;
        public double height;

        public Rhombus(double side, double height)
        {
            if (side <= 0 || height <= 0)
                throw new ArgumentException("Side or height can not be equal to 0 or less than 0");
            else if (height > side)
                throw new ArgumentException("Height can not be greater than side");

            this.side = side;
            this.height = height;
        }
        public double GetArea()
        {
            double area = side * height;

            return area;
        }
    }
}
