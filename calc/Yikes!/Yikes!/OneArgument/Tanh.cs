using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class TanH : IOnearg
    {
        /// <summary>
        /// Calculate function TanH(x)
        /// </summary>
        /// <param name="num"></param>
        /// tanH(x) is calculate
        /// <returns>
        /// Returns result tanH (x)
        /// </returns>
        public double Calculate(double num)
        {
            return Math.Tanh(num);
        }
    }
}

