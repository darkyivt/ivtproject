using System;

namespace Yikes_.OneArgument
{
    public
        class CosCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Cosinus(x)
        /// </summary>
        /// <param name="num"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result cosinus (x)
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Cos(num);
            return (endres);
        }
    }
}

