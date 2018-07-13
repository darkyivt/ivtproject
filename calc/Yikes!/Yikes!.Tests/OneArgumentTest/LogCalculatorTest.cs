using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class LogTenCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            LogTenCalculator logten = new LogTenCalculator();
            double ExpResult = Log(testnum, 10), ActResult = logten.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}