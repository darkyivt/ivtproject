using System;

namespace Yikes_.OneArgument
{
    public
        class Fivestep : IOneArgument
    {
        /// <summary>
        /// Calculate function fivestep (x)
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// arctan(x) is calculate
        /// <returns>
        /// Returns result fivestep (x)
        /// </returns>
        public
            double Calculate(double FirstArgument)
        {
            double endres = 0;
            endres = Math.Pow(FirstArgument, 5);
            return (endres);
        }
    }
}
