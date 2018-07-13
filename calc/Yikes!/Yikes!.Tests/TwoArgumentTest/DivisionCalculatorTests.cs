﻿using System;
using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(6, 2, 3)]
        [TestCase(4, 4, 1)]
        [TestCase(-18, -2, 9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        [TestCase(-10, 0)]
        public void ExceptionZeroTest(double firstArgument, double secondArgument)
        {
            var calculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArgument, secondArgument));
        }
    }
}