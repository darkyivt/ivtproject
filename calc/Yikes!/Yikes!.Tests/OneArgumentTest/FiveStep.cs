using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class FiveStepTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(7)]
        public
            void CalcTests(double testnum)
        {
            Fivestep fivestep = new Fivestep();
            double ExpResult = Math.Pow(testnum, 5), ActResult = fivestep.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
