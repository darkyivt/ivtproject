using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
{
    class ModTests
    {
        [TestCase(13)]
        [TestCase(24)]
        [TestCase(17)]
        public
            void CalcTests(double testnum)
        {
            SquareCalculator sqare = new SquareCalculator();
            double ExpResult = Abs(testnum), ActResult = sqare.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}