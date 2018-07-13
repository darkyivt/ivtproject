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
        /// <param name="SecondArgument"></param>
        /// Check num1
        /// if num1==0
        /// then error
        /// <returns>
        ///Returns result logarithm finction
        /// </returns>

        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres = 0;
            if (FirstArgument == 0)
            {
                throw new Exception("Нулевой логарифм не существует");
            }
            endres = Math.Log(FirstArgument, SecondArgument);
            return (endres);
        }


    }
}

