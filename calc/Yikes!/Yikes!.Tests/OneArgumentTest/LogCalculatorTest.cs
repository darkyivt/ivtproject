using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class LogTenCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            LogTenCalculator logten = new LogTenCalculator();
            double ExpResult = Math.Log(testnum, 10), ActResult = logten.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}