using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
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
            double ExpResult = Pow(testnum, 5), ActResult = fivestep.Calculate(testnum);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}
