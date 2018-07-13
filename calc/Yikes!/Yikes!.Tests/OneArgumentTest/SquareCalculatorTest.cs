using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class SquaringTest
    {
        [TestCase(12, 144)]
        [TestCase(30, 900)]
        [TestCase(11, 121)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SquareCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}