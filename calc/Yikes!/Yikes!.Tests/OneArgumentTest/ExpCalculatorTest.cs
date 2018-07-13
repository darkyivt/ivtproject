using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ExpCalculatorTests
    {
        [TestCase(0,1)]
        [TestCase(1,2.7)]
        [TestCase(2,7.8)]
        public
            void CalcTests(double testnum)
        {
            ExpCalculator expc = new ExpCalculator();
            double expResult = Math.Exp(testnum), actResult = expc.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}
