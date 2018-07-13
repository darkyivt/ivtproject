using System;

namespace Yikes_.OneArgument
{
    public
        class CosCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Cosinus(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result cosinus (x)
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            double endres = 0;
            endres = Math.Cos(firstArgument);
            return (endres);
        }
    }
}

