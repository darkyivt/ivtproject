using System;

namespace Yikes_.TwoArgument
{
    public
        class PowCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function Pow
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// <param name="SecondArgument"></param>
        /// Check two arguments
        /// <returns>
        /// Result NumberPow of two argument
        /// </returns>
        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres = 0;
            endres = Math.Pow(FirstArgument, SecondArgument);
            return (endres);
        }
    }
}
