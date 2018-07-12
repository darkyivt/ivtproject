using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;
using Yikes_.TwoArgument;

namespace Yikes_.Tests
{
    [TestFixture]
    public
   class CalculateTwoArgTests
    {
        [TestCase("bplus", typeof(AdditionCalculator))]
        [TestCase("bdiv", typeof(DivisionCalculator))]
        [TestCase("bmult", typeof(MultiplyCalculator))]
        [TestCase("bminus", typeof(SubstractionCalculator))]
        [TestCase("bpow", typeof(PowCalculator))]
        [TestCase("blog", typeof(LogCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator =FactoryTwoArg.CreateCalculator(name);
            Assert.IsInstanceOf(type,calculator);
        }
    }
}
