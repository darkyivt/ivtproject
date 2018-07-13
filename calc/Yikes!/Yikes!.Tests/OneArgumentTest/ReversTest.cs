using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class ReversTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ReverseNumber rad = new ReverseNumber();
            double ExpResult = 1 / testnum, ActResult = rad.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}