using System;

namespace Yikes_.TwoArgument
{
    public
        class PowCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function Pow
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check two arguments
        /// <returns>
        /// Result NumberPow of two argument
        /// </returns>
        public
            double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument); 
        }
    }
}
