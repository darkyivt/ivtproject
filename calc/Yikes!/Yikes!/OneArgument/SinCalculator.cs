using System;

namespace Yikes_.OneArgument
{
    public
        class SinCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Sinus 
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// Sinus is calculate
        /// <returns>
        /// Returns result function Sinus
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Sin(FirstArgument);
            return (endres);
        }
    }
}
