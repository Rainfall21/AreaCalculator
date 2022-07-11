using System;
using AreaLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLibraryTests
{
    [TestClass]
    public class GetAreaTests
    {
        [TestMethod]
        public void GetAreaTriangleWithSides10_15_20_72returned()
        {
            double sideA = 10;
            double sideB = 15;
            double sideC = 20;
            double expected = 72.62;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actual = Math.Round(triangle.GetArea(), 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAreaCircleWithRadius7_154returned()
        {
            double radius = 7;
            double expected = 153.9;

            Circle circle = new Circle(radius);
            double actual = Math.Round(circle.GetArea(),1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAreaParallelogramWithSide10Height15_150returned()
        {
            double side = 10;
            double height = 15;
            double expected = 150;

            Parallelogram parallelogram = new Parallelogram(side, height);
            double actual = parallelogram.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetAreaTrapezoidWithSideA10SideB12SideC8SideD9_80returned()
        {
            double sideA = 10;
            double sideB = 12;
            double sideC = 8;
            double sideD = 9;
            double expected = 80;

            Trapezoid trapezoid = new Trapezoid(sideA, sideB, sideC,sideD);

            double actual = Math.Round(trapezoid.GetArea(),0);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsTriangleRightWithSideA3SideB4SideC5_IsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool actual = triangle.RightAngle();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsTriangleRightWithSideA3SideB4SideC6_IsFalse()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool actual = triangle.RightAngle();

            Assert.IsFalse(actual);
        }
    }
}
