using System;

namespace Yikes_.OneArgument
{
    public
        class ModCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Mod
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns>
        /// returns result  function Mod
        /// </returns>
        public
            double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
