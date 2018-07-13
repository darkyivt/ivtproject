using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class LogTenCalculatorTests
    {
        [TestCase(3, 1.3)]
        [TestCase(9, 2.3)]
        [TestCase(27, 3.5)]
        public
            void CalcTests(double testnum)
        {
            LogTenCalculator logten = new LogTenCalculator();
            double expResult = Math.Log(testnum, 10), actResult = logten.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}