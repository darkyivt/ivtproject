using System;

namespace Yikes_.OneArgument
{
    public
        class SquareCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Square
        /// </summary>
        /// <param name="num"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Square
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Pow(num, 2);
            return (endres);
        }
    }
}

