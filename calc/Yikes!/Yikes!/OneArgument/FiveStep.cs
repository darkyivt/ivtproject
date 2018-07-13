using System;

namespace Yikes_.OneArgument
{
    public
        class Fivestep : IOneArgument
    {
        /// <summary>
        /// Calculate function fivestep (x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result fivestep (x)
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, 5);
        }
    }
}
