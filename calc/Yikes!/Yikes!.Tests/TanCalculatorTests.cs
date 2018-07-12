using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using static System.Math;
using Yikes_;
namespace Yikes_.Tests
{
    [TestFixture]
    public
    class TanCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTanTests(double testnum)
        {
            TanCalculator tanc = new TanCalculator();
            double ExpResult = Tan(testnum), ActResult = tanc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
