using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class LnCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcLogTests(double testnum)
        {
            LnCalculator logc = new LnCalculator();
            double ExpResult = Math.Log(testnum), ActResult = logc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
