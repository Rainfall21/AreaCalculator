using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Circle : IFigure
    {
        public double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius can not be equal to 0 or less than 0", nameof(radius));

            this.radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
