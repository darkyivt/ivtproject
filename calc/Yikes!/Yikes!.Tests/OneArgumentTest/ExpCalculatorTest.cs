using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ExpCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ExpCalculator expc = new ExpCalculator();
            double ExpResult = Math.Exp(testnum), ActResult = expc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
