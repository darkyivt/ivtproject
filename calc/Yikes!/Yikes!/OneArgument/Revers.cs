using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_.OneArgument
{
    public class ReverseNumber : IOnearg
    {
        /// <summary>
        /// Calculate function ReverseNumber
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check firstArgument 
        /// if firstArgument ==0
        /// then error
        /// <returns>
        /// Returns function ReverseNumber
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1 / firstArgument;
        }
    }
}
