using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    class FiveStepTests
    {
        [TestCase(1,1)]
        [TestCase(2,32)]
        [TestCase(3,243)]
        public
            void CalcTests(double testnum)
        {
            Fivestep fivestep = new Fivestep();
            double expResult = Math.Pow(testnum, 5), actResult = fivestep.Calculate(testnum);
            Assert.AreEqual(expResult, actResult);
        }
    }
}
