using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.TwoArgument;
using static System.Math;
namespace Yikes_.Tests
{
    [TestFixture]
    public
        class MultiplyCalculatorTests
    {
        [TestCase(66, 33)]
        [TestCase(33, 3)]
        [TestCase(12, 33)]
        public
            void CalcMetTests(double firstarg, double secarg)
        {
            MultiplyCalculator mulc = new MultiplyCalculator();
            double ExpResult = firstarg * secarg, ActResult = mulc.Calculate(firstarg, secarg);
            Assert.AreEqual(ExpResult, ActResult);
        }
    }
}