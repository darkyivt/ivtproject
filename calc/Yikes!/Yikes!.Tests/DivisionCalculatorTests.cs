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
    class DivisionCalculatorTests
    {
        [Test]
        public
                  void CalcMetTests()
        {
            DivisionCalculator divc = new DivisionCalculator();
            double ExpResult = 66 / 33, ActResult = divc.CalcMet(66, 33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
