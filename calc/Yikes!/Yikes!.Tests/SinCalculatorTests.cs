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
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
               void CalcSinTests(double typein)
        {
            SinCalculator sinc = new SinCalculator();
            double ExpResult = Sin(typein), ActResult = sinc.CalcSin(typein);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
