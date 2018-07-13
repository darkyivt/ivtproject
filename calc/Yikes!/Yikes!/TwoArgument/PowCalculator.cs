using System;

namespace Yikes_.TwoArgument
{
    public
        class PowCalculator : ITwoarg
    {
        /// <summary>
        /// Calculate function Pow
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// Check two arguments
        /// <returns>
        /// Result NumberPow of two argument
        /// </returns>
        public
            double Calculate(double num1, double num2)
        {
            double endres = 0;
            endres = Math.Pow(num1, num2);
            return (endres);
        }
    }
}
