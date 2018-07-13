using System;

namespace Yikes_.OneArgument
{
    public class LogTenCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Log10
        /// </summary>
        /// <param name="num"></param>
        /// Check num less than 0
        /// then error
        /// Check num==0
        /// then error 
        /// <returns>
        /// returns result  function log10
        /// </returns>
        public double Calculate(double num)
        {
            if (num < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            if (num == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log10(num);
        }
    }
}