using System;

namespace Yikes_.TwoArgument
{
    public
        class DivisionCalculator : ITwoarg
    {
        /// <summary>
        /// Calculate function division
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// Check num2 
        /// if num2 is 0
        /// then error
        /// <returns>
        /// returns result division of two argument
        /// </returns>
        public
            double Calculate(double num1, double num2)
        {
            double endres;
            if (num2 == 0)
            {
                endres = 0;
                throw new Exception("На ноль делить нельзя.");
            }
            return num1 / num2;

        }
    }
}
