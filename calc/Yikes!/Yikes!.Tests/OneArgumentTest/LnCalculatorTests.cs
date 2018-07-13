using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class LnCalculatorTests
    {
        [TestCase(3,1.3)]
        [TestCase(9,2.3)]
        [TestCase(27,3.5)]
        public
            void CalcLogTests(double testnum)
        {
            LnCalculator logc = new LnCalculator();
            double expResult = Math.Log(testnum), actResult = logc.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}
