using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
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
            double ExpResult = Log(testnum), ActResult = logc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
