﻿namespace Yikes_.TwoArgument
{
    public
    class MultiplyCalculator: ITwoarg
    {
        public
           double Calculate(double num1, double num2)
        {
            double endres;
            endres = num1 * num2;
            return (endres);
        }
    }
}