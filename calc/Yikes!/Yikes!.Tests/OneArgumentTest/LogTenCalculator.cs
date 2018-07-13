using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class ModCalculatorTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ModCalculator modc = new ModCalculator();
            double ExpResult = Abs(testnum), ActResult = modc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}