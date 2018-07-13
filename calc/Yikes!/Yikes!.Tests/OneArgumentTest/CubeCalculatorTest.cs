using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class CubeTest
    {
        [TestCase(2, 8)]
        [TestCase(3, 27)]
        [TestCase(5, 125)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CubeCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}