using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibrary
{
    public class Triangle : IFigure
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)

                throw new ArgumentException("Sides can not be equal to 0 or less than 0");

            else if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)

                throw new ArgumentException("Triangle with these parameters can not exist");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double GetArea()
        {
            double p = ((sideA + sideB + sideC) / 2);

            double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            
            if(RightAngle() == true)
                Console.WriteLine("Area of this RIGHT triangle is " + area);
            else
                Console.WriteLine("Area of this triangle is " + area);
            return area;
        }   
        public bool RightAngle()
        {
            return (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
                    || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
                    || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }
    }
}
