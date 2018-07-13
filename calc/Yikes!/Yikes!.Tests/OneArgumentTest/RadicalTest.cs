using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class RadicalTests
    {
        [TestCase(3,5)]
        [TestCase(6,8)]
        [TestCase(7,10)]
        public
            void CalcTests(double testnum)
        {
            Arccos rad = new Arccos();
            double expResult = Math.Pow(testnum, 1f / 2f), actResult = rad.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}
