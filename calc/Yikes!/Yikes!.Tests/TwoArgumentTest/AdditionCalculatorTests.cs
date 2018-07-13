using NUnit.Framework;
using Yikes_.TwoArgument;

namespace Yikes_.Tests.TwoArgumentTest
{
    [TestFixture]
    public class AddTest
    {
        public class AddTests
        {
            [TestCase(0, 0, 0)]
            [TestCase(3, 4, 7)]
            [TestCase(-7, -2, -9)]
            public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new AdditionCalculator();
                var actualResult = calculator.Calculate(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }
        }
    }
}
