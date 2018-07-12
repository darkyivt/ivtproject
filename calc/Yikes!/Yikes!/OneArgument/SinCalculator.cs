using System;

namespace Yikes_.OneArgument
{
    public
    class SinCalculator: IOnearg
    {
        public
        double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Sin(num);
            return (endres);
        }
    }
}
