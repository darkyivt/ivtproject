using System;

namespace Yikes_.OneArgument
{
    public
        class SquareCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Square
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Square
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Pow(FirstArgument, 2);
            return (endres);
        }
    }
}

