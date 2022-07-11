using System;

namespace AreaLibrary
{
    public class Calculation
    {
        public double[] Start()
        {
            Console.WriteLine("Enter known parameters separated by commas");
            string[] parameters = Console.ReadLine().Split(',');
            double[] validParameters = Array.ConvertAll(parameters, new Converter<string, double>(Double.Parse));

            return validParameters;
        }
        public double Calculate(double[] validParameters)
        {

            switch (validParameters.Length)
            {
                case 0:
                    throw new ArgumentNullException("There are no figures with its parameter equal to 0");
                case 1:
                    Circle circle = new Circle(validParameters[0]);
                    return circle.GetArea();
                case 2:
                    Parallelogram parallelogram = new Parallelogram(validParameters[0], validParameters[1]);
                    return parallelogram.GetArea();
                case 3:
                    Triangle triangle = new Triangle(validParameters[0], validParameters[1], validParameters[2]);
                    return triangle.GetArea();
                case 4:
                    Trapezoid trapezoid = new Trapezoid(validParameters[0], validParameters[1], validParameters[2], validParameters[3]);
                    return trapezoid.GetArea();

                default:
                    throw new ArgumentException("Can't calculate figure with too many sides. Add a formula to calculate");
            }
        }
    }
}
