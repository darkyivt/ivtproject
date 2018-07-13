using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
{
    [TestFixture]
    public class LogCalculatorTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double firstnum, double secondnum, double expected)
        {
            var calculator = new LogCalculator();
            var actualResult = calculator.Calculate(firstnum, secondnum);
            Assert.AreEqual(expected, actualResult);
        }
    }
}