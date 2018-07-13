using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests
{
    [TestFixture]
    public class PowCalculatorTest
    {
        [TestCase(0, 0, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(-2, 3, -8)]
        public void CalculateTest(double firstnum, double secondnum, double expected)
        {
            var calculator = new PowCalculator();
            var actualResult = calculator.Calculate(firstnum, secondnum);
            Assert.AreEqual(expected, actualResult);
        }
    }
}