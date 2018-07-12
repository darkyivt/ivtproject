using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Yikes_.OneArgument;

namespace Yikes_.Tests
{
    [TestFixture]
    public
        class CalculateOneArgTests
    {
        [TestCase("bsin", typeof(SinCalculator))]
        [TestCase("bcos", typeof(CosCalculator))]
        [TestCase("btan", typeof(TanCalculator))]
        [TestCase("bsquare", typeof(SquareCalculator))]
        [TestCase("bmod", typeof(ModCalculator))]
        [TestCase("bexp", typeof(ExpCalculator))]
        [TestCase("bl10", typeof(LogTenCalculator))]
        [TestCase("bcube", typeof(CubeCalculator))]
        [TestCase("bln", typeof(LnCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = FactoryOneArg.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
