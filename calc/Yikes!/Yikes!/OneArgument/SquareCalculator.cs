using System;

namespace Yikes_.OneArgument
{
    public
        class SquareCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Square
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Square
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 2);
        }
    }
}

