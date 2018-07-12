using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class CosCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
                  void CalcSinTests(double testnum)
        {
            CosCalculator cosc = new CosCalculator();
            double ExpResult = Cos(testnum), ActResult = cosc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
