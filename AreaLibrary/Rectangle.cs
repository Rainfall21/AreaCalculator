using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Rectangle : IFigure
    {
        public double side;
        public double height;
        public Rectangle(double side, double height)
        {
            if (side <= 0 || height <= 0)
                throw new ArgumentException("Sides and height can not be equal to 0 or less than 0");

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
