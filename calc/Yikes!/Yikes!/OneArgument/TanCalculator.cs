﻿using System;

namespace Yikes_.OneArgument
{
    public
        class TanCalculator : IOnearg
    {
        /// <summary>
        /// Calculate function Tg(x)
        /// </summary>
        /// <param name="num"></param>
        /// tg(x) is calculate
        /// <returns>
        /// Returns result function tg(x)
        /// </returns>
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Tan(num);
            return (endres);
        }
    }
}

