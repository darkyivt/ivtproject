using System;

namespace Yikes_.OneArgument
{
    public class Sqrt : IOneArgument
    {
        /// <summary>
        /// Calculate function Sqrt
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Squaring
        /// </returns>
        public double Calculate(double FirstArgument)
        {
            return Math.Pow(FirstArgument, 0.5);
        }
    }
}