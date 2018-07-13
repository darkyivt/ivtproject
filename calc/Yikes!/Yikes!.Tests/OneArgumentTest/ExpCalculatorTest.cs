using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
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
            double ExpResult = Exp(testnum), ActResult = expc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
