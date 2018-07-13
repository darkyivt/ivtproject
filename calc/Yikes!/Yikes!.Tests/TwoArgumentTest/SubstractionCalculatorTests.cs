﻿using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
{
    [TestFixture]
    public class SubstractionTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new SubstractionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
