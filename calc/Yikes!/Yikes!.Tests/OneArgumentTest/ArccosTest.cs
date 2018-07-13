using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class ArccosinusTest
    {
        [TestCase(0.9, 0.4510)]
        [TestCase(0.6, 0.9272)]
        [TestCase(0.5, 1.0471)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arccos();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }
        [TestCase(-2)]
        [TestCase(2)]
        public void ExceptionTest(double firstArgument)
        {
            var calculator = new Arccos();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}
