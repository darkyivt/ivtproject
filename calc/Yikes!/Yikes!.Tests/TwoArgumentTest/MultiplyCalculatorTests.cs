using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
{
    [TestFixture]
    public class MultiplyTest
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(-7, -2, 14)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}