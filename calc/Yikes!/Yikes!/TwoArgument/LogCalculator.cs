using System;

namespace Yikes_.TwoArgument
{
    public
        class LogCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate Logarithm function
        /// </summary>
        /// <param name="FirsArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check num1
        /// if num1==0
        /// then error
        /// <returns>
        ///Returns result logarithm finction
        /// </returns>

        public
            double Calculate(double firstArgument, double secondArgument)
        {
            double endres = 0;
            if (firstArgument == 0)
            {
                throw new Exception("Нулевой логарифм не существует");
            }
            return Math.Log(firstArgument, secondArgument); ;
        }


    }
}

