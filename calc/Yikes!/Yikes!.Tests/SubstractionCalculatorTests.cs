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
    class SubstractionCalculatorTests
    {
        [Test]
        public
                        void CalcMetTests()
        {
            SubstractionCalculator mulc = new SubstractionCalculator();
            double ExpResult, ActResult;
            ExpResult = 66 - 33;
            ActResult = mulc.CalcMet(66, 33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
