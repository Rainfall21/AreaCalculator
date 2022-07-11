using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;

namespace AreaTest
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CalculateTestWithCaseCircle_154Returned()
        {
            double[] validParameters = new double[1] { 7 };
            double expected = 154;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTestWithCaseParallelogram_150Returned()
        {
            double[] validParameters = new double[2] { 10,15 };
            double expected = 150;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters), 1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTestWithCaseTriangleWithSides10_15_20_73Returned()
        {
            double[] validParameters = new double[3] { 10, 15, 20 };
            double expected = 73;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters));
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTestWithCaseTrapezoidWithSides8_9_10_12_80Returned()
        {
            double[] validParameters = new double[4] { 10,12,8,9 };
            double expected = 80;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters));
            Assert.AreEqual(expected, actual);
        }
    }
}
