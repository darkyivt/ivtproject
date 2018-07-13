using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public class InverseNumberTest
    {
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        [TestCase(5, 0.2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ReverseNumber();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
        [TestCase(0)]
        public void ExceptionTest(double firstArgument)
        {
            var calculator = new ReverseNumber();();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument));
        }
    }
}