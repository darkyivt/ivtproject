using System;

namespace Yikes_.OneArgument
{
    public class LnCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Logarithm
        /// </summary>
        /// <param name="num"></param>
        /// Check num less than 0
        /// then error
        /// Check num==0
        /// then error 
        /// <returns>
        /// Returns result function logarithm
        /// </returns>
        public double Calculate(double num)
        {
            if (num < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            else if (num == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log(num);
        }
    }
}