using System;

namespace Yikes_.OneArgument
{
    public
        class CubeCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Cube (x)
        /// </summary>
        /// <param name="FirstArgument></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result Cube (x)
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Pow(FirstArgument, 3);
            return (endres);
        }
    }
}
