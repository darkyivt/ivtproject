using System;
using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
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
            var calculator = FactoryTwoArg.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

