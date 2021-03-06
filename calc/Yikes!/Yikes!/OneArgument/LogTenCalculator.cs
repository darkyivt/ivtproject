﻿using System;

namespace Yikes_.OneArgument
{
    public class LogTenCalculator : IOneArgument
    {
        /// <summary>
        /// Calculate function Log10
        /// </summary>
        /// <param name="firstArgument"></param>
        /// Check num less than 0
        /// then error
        /// Check num==0
        /// then error 
        /// <returns>
        /// returns result  function log10
        /// </returns>
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            if (firstArgument == 0)
            {
                throw new Exception("Бесконечно убывает");
            }
            return Math.Log10(firstArgument);
        }
    }
}