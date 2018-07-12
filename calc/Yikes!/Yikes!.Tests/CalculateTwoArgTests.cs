using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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
        public void CalculateTest(string name, Type type)
        {
            var calculator =FactoryTwoArg.CreateCalculator(name);
            Assert.IsInstanceOf(type,calculator);
        }
    }
}
