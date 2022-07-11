using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLibrary;

namespace AreaTest
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "There are no figures with its parameter equal to 0")]
        public void CalculateTestWithCase0_ExceptionReturned()
        {
            double[] validParameters = new double[0];
            Calculation calculation = new Calculation();
            double actual = calculation.Calculate(validParameters);
        }

        [TestMethod]
        public void CalculateTestWithCase1_154Returned()
        {
            double[] validParameters = new double[1] { 7 };
            double expected = 153.9;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters),1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateTestWithCase2_150Returned()
        {
            double[] validParameters = new double[2] { 10,15 };
            double expected = 150;
            Calculation calculation = new Calculation();
            double actual = Math.Round(calculation.Calculate(validParameters), 1);
            Assert.AreEqual(expected, actual);
        }
    }
}
