using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
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
            double ExpResult = Math.Pow(testnum, 1f / 2f), ActResult = rad.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
