using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class Arccos : IOnearg
    {
        /// <summary>
        /// Calculates  Arccos(x) function
        /// </summary>
        /// <param name="num"></param>
        /// Check firstArgument
        /// if firstArgument more than 1 or first argument less than -1
        /// then error
        /// <returns>
        /// Return function Arccos (x)
        /// </returns>
        public double Calculate(double num)
        {
            if (num > 1 || num < -1)
            {
                throw new Exception("Недопустимое значение");
            }

            return Math.Acos(num);
        }
    }
}
