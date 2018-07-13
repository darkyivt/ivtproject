using System;

namespace Yikes_.OneArgument
{
    public
        class CubeCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Cube (x)
        /// </summary>
        /// <param name="num"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result Cube (x)
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Pow(num, 3);
            return (endres);
        }
    }
}
