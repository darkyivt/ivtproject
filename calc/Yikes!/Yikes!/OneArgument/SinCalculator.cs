using System;

namespace Yikes_.OneArgument
{
    public
        class SinCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Sinus 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Sinus is calculate
        /// <returns>
        /// Returns result function Sinus
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
