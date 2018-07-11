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
    class AdditionCalculatorTests
    {
        [Test]
        public
               void CalcMetTests()
        {
            AdditionCalculator addc = new AdditionCalculator();
            double ExpResult, ActResult;
            ExpResult = 33+66;
            ActResult = addc.CalcMet(33, 66);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
