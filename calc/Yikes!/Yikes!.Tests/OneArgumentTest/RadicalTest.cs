using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class RadicalTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            Arccos rad = new Arccos();
            double ExpResult = Pow(testnum, 1f / 2f), ActResult = rad.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
