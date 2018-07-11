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
    class MultiplyCalculatorTests
    {
        [Test]
        public
                     void CalcMetTests()
        {
            MultiplyCalculator mulc = new MultiplyCalculator();
            double ExpResult, ActResult;
            ExpResult = 66 * 33;
            ActResult = mulc.CalcMet(66, 33);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
