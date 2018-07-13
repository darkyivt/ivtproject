using System;

namespace Yikes_.OneArgument
{
    public class Sqrt : IOneArgument
    {
        /// <summary>
        /// Calculate function Sqrt
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Squaring
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 0.5);
        }
    }
}