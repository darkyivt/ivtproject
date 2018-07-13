using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class ArcSin : IOnearg
    {
        /// <summary>
        ///  Calculate function Arcsin(x)
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument
        /// if firstArgument more than 1 or first argument less than -1
        /// then error
        /// <returns>
        /// Return function Arcsin (x)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Недопустимое значение");
            }
            return Math.Asin(firstArgument);
        }
    }
}
