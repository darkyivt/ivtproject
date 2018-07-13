using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class SinusTest
    {
        [TestCase(70, 0.7738)]
        [TestCase(45, 0.8509)]
        [TestCase(60, -0.3048)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
