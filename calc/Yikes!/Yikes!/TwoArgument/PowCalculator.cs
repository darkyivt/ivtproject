using System;

namespace Yikes_.TwoArgument
{
    public
        class PowCalculator : ITwoarg
    {
        public
            double Calculate(double num1, double num2)
        {
            double endres = 0;
            endres = Math.Pow(num1, num2);
            return (endres);
        }
    }
}
