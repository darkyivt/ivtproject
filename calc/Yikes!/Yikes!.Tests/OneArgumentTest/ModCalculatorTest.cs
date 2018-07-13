using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ModTests
    {
        [TestCase(13,13)]
        [TestCase(-24,24)]
        [TestCase(-17,17)]
        public
            void CalcTests(double testnum)
        {
            SquareCalculator sqare = new SquareCalculator();
            double expResult = Math.Abs(testnum), actResult = sqare.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}