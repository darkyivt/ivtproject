using System;

namespace Yikes_.OneArgument
{
    public
        class CubeCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Cube (x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result Cube (x)
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 3);
        }
    }
}
