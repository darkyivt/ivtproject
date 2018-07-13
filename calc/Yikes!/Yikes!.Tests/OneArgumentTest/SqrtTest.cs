using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using static System.Math;

namespace Yikes_.Tests
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
            double ExpResult = Pow(typein,2), ActResult = sinc.Calculate(typein);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}

