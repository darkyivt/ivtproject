using System;

namespace Yikes_.OneArgument
{
    public
        class ModCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Mod
        /// </summary>
        /// <param name="num"></param>
        /// <returns>
        /// returns result  function Mod
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Abs(num);
            return (endres);
        }
    }
}
