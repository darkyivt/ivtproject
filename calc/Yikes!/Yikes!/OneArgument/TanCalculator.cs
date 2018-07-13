using System;

namespace Yikes_.OneArgument
{
    public
        class TanCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Tg(x)
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// tg(x) is calculate
        /// <returns>
        /// Returns result function tg(x)
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Tan(FirstArgument);
            return (endres);
        }
    }
}

