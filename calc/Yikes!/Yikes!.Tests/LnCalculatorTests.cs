using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using static System.Math;

namespace Yikes_.Tests
{
    class LnCalculatorTests
    {
        [Test]
        public
               void CalcLogTests()
        {
            LnCalculator logc = new LnCalculator();
            double ExpResult = Log(33), ActResult = logc.CalcLog(33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
