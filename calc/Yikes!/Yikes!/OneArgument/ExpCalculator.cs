using System;

namespace Yikes_.OneArgument
{
    public
        class ExpCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function exp(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result exp (x)
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}