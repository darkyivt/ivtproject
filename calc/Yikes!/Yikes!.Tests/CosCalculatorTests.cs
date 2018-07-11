using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using static System.Math;

namespace Yikes_.Tests
{
    class CosCalculatorTests
    {
        [Test]
        public
                  void CalcSinTests()
        {
            CosCalculator cosc = new CosCalculator();
            double ExpResult, ActResult;
            ExpResult = Cos(33);
            ActResult = cosc.CalcCos(33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
