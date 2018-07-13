using System;

namespace Yikes_.OneArgument
{
    public
        class ModCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Mod
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// <returns>
        /// returns result  function Mod
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Abs(FirstArgument);
            return (endres);
        }
    }
}
