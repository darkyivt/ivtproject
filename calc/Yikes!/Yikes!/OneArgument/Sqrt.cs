using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class Sqrt : IOnearg
    {
        /// <summary>
        /// Calculate function Sqrt
        /// </summary>
        /// <param name="num"></param>
        /// Squaring is calculate
        /// <returns>
        /// Returns result function Squaring
        /// </returns>
        public double Calculate(double num)
        {
            return Math.Pow(num, 0.5);
        }
    }
}