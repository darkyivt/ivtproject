using System;

namespace Yikes_.OneArgument
{
    public
        class ExpCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function exp(x)
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result exp (x)
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Exp(FirstArgument);
            return (endres);
        }
    }
}