using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using static System.Math;

namespace Yikes_.Tests
{
    [TestFixture]
    public
    class SinCalculatorTests
    {
        [Test]
        public
               void CalcSinTests()
        {
            SinCalculator sinc = new SinCalculator();
            double ExpResult, ActResult;
            ExpResult = Sin(33);
            ActResult = sinc.CalcSin(33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
