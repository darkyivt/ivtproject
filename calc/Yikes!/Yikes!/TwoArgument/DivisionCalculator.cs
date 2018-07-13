using System;

namespace Yikes_.TwoArgument
{
    public
        class DivisionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function division
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// <param name="SecondArgument"></param>
        /// Check num2 
        /// if num2 is 0
        /// then error
        /// <returns>
        /// returns result division of two argument
        /// </returns>
        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres;
            if (SecondArgument == 0)
            {
                endres = 0;
                throw new Exception("На ноль делить нельзя.");
            }
            return FirstArgument / SecondArgument;

        }
    }
}
