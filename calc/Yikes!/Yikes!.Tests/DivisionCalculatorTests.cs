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
        [TestCase(66, 33)]
        [TestCase(33, 3)]
        [TestCase(12, 33)]
        public
                  void CalcMetTests(double firstarg, double secarg)
        {
            DivisionCalculator divc = new DivisionCalculator();
            double ExpResult = firstarg / secarg, ActResult = divc.CalcMet(firstarg, secarg);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
