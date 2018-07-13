using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public
        class Fivestep : IOnearg
    {
        /// <summary>
        /// Calculate function fivestep (x)
        /// </summary>
        /// <param name="num"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result fivestep (x)
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Pow(num, 5);
            return (endres);
        }
    }
}
