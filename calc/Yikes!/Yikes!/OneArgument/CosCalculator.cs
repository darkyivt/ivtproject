using System;

namespace Yikes_.OneArgument
{
    public
        class CosCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Cosinus(x)
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result cosinus (x)
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Cos(FirstArgument);
            return (endres);
        }
    }
}

