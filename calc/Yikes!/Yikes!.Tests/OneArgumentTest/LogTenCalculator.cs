using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ModCalculatorTests
    {
        [TestCase(100, 2)]
        [TestCase(10, 1)]
        [TestCase(1000, 3)]
        public
            void CalcTests(double testnum)
        {
            ModCalculator modc = new ModCalculator();
            double expResult = Math.Abs(testnum), actResult = modc.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}