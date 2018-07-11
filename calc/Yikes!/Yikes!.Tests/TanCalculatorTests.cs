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
        [Test]
        public
            void CalcTanTests()
        {
            TanCalculator tanc = new TanCalculator();
            double ExpResult, ActResult;
            ExpResult = Tan(33);
            ActResult = tanc.CalcTan(33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
