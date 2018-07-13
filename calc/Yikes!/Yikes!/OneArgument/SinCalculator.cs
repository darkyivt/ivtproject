using System;

namespace Yikes_.OneArgument
{
    public
        class SinCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Sinus 
        /// </summary>
        /// <param name="num"></param>
        /// Sinus is calculate
        /// <returns>
        /// Returns result function Sinus
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Sin(num);
            return (endres);
        }
    }
}
