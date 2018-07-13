using System;

namespace Yikes_.OneArgument
{
    public class LnCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Logarithm
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// Check num less than 0
        /// then error
        /// Check num==0
        /// then error 
        /// <returns>
        /// Returns result function logarithm
        /// </returns>
        public double Calculate(double FirstArgument)
        {
            if (FirstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            else if (FirstArgument == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log(FirstArgument);
        }
    }
}