using System;

namespace Yikes_.TwoArgument
{
    public
        class DivisionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function division
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check num2 
        /// if num2 is 0
        /// then error
        /// <returns>
        /// returns result division of two argument
        /// </returns>
        public
            double Calculate(double firstArgument, double secondArgument)
        {
            double endres;
            if (secondArgument == 0)
            {
                endres = 0;
                throw new Exception("На ноль делить нельзя.");
            }
            return firstArgument / secondArgument;

        }
    }
}
