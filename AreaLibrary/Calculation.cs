using System;
using AreaLibrary.Figures;

namespace AreaLibrary
{
    public class Calculation
    {
        public void Start()
        {
            Console.WriteLine("Enter known parameters separated by commas");
            string[] parameters = Console.ReadLine().Split(',');
            double[] validParameters = Array.ConvertAll(parameters, new Converter<string, double>(Double.Parse));
            if (validParameters.Length == 0)
                throw new ArgumentNullException("There are no parameters");

            Calculation calculation = new Calculation();

            var calculate = calculation.Calculate(validParameters);
        }

        public double Calculate(double[] validParameters)
        {
            return GetFigure(validParameters).GetArea();
        }
        private IFigure GetFigure(double[] validParameters)
        {
            var figureType = (FigureType)validParameters.Length;
            switch (figureType)
            {
                case FigureType.Circle:
                    return new Circle(validParameters[0]);
                case FigureType.Parallelogram:
                    return new Parallelogram(validParameters[0], validParameters[1]);
                case FigureType.Triangle:
                    return new Triangle(validParameters[0], validParameters[1], validParameters[2]);
                case FigureType.Trapezoid:
                    return new Trapezoid(validParameters[0], validParameters[1], validParameters[2], validParameters[3]);
            }
            return null;
        }
    }
}
