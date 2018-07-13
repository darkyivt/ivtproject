using System;

namespace Yikes_.OneArgument
{
    public
        class ExpCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function exp(x)
        /// </summary>
        /// <param name="num"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result exp (x)
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Exp(num);
            return (endres);
        }
    }
}