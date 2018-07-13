using System;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests.OneArgumentTest
{
    [TestFixture]
    public
        class SquareTests
    {
        [TestCase(33)]
        [TestCase(66)]
        [TestCase(77)]
        public
            void CalcTests(double typein)
        {
            SinCalculator sinc = new SinCalculator();
            double ExpResult = Math.Pow(typein,2), ActResult = sinc.Calculate(typein);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}

