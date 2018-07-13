using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class ArcTan : IOnearg
    {
        /// <summary>
        /// Calculate function Arctan(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result arctan (x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);

        }
    }
}
