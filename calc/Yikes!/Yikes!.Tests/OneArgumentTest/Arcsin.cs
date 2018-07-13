using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class ArcSinusTest
    {
        [TestCase(0.7, 0.7754)]
        [TestCase(0.45, 0.4668)]
        [TestCase(1, 1.5708)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcSin();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
        [TestCase(-2)]
        [TestCase(2)]
        public void ExceptionTest(double firstArgument)
        {
            var calculator = new ArcSin();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}