using System;
using Yikes_.TwoArgument;

namespace Yikes_.TwoArgument
{
    public
        class LogCalculator : ITwoarg
    {
        /// <summary>
        /// Calculate Logarithm function
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// Check num1
        /// if num1==0
        /// then error
        /// <returns>
        ///Returns result logarithm finction
        /// </returns>

        public
            double Calculate(double num1, double num2)
        {
            double endres = 0;
            if (num1 == 0)
            {
                throw new Exception("Нулевой логарифм не существует");
            }
            endres = Math.Log(num1, num2);
            return (endres);
        }


    }
}

