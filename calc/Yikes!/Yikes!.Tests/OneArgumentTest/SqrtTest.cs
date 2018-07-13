using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public
        class SquareTests
    {
        [TestCase(9,3)]
        [TestCase(25,5)]
        [TestCase(36,6)]
        public
            void CalcTests(double typein)
        {
            SinCalculator sinc = new SinCalculator();
            double expResult = Math.Pow(typein,2), actResult = sinc.Calculate(typein);
            Assert.AreEqual(expResult, actResult);
        }
    }
}

