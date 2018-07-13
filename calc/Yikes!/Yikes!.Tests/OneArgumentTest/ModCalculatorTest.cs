using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
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
            double ExpResult = Math.Abs(testnum), ActResult = sqare.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}