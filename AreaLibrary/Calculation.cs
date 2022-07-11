using System;
using AreaLibrary.Figures;

namespace AreaLibrary
{
    public class Calculation
    {
        public double[] Start()
        {
            Console.WriteLine("Enter known parameters separated by commas");
            string[] parameters = Console.ReadLine().Split(',');
            double[] validParameters = Array.ConvertAll(parameters, new Converter<string, double>(Double.Parse));
            if (validParameters.Length == 0)
                throw new ArgumentNullException("There are no parameters");

            return validParameters;
        }
        public double Calculate(double[] validParameters)
        {
            var figureType = (FigureType)validParameters.Length;
            IFigure figure = null;
            switch (figureType)
            {
                case FigureType.Circle:
                    figure = new Circle(validParameters[0]);
                    break;
                case FigureType.Parallelogram:
                    figure = new Parallelogram(validParameters[0], validParameters[1]);
                    break;
                case FigureType.Triangle:
                    figure = new Triangle(validParameters[0], validParameters[1], validParameters[2]);
                    break;
                case FigureType.Trapezoid:
                    figure = new Trapezoid(validParameters[0], validParameters[1], validParameters[2], validParameters[3]);
                    break;
            }
            return figure.GetArea();
        }
    }
}
