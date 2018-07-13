using System;

namespace Yikes_.OneArgument
{
    public class TanH : IOneArgument
    {
        /// <summary>
        /// Calculate function TanH(x)
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// tanH(x) is calculate
        /// <returns>
        /// Returns result tanH (x)
        /// </returns>
        public double Calculate(double FirstArgument)
        {
            return Math.Tanh(FirstArgument);
        }
    }
}

