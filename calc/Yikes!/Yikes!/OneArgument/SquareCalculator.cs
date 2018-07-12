using System;

namespace Yikes_.OneArgument
{
    public
        class SquareCalculator : IOnearg
    {
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Pow(num,2);
            return (endres);
        }
    }
}
