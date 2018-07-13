using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class ArcCtgTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double testnum)
        {
            ArcCtg arcctgc = new ArcCtg();
            double ExpResult = 1 / Math.Atan(testnum), ActResult = arcctgc.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
