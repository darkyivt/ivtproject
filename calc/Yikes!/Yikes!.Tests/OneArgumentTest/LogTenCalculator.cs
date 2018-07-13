using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ModCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ModCalculator modc = new ModCalculator();
            double ExpResult = Math.Abs(testnum), ActResult = modc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}