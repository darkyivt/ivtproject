using System;

namespace Yikes_.OneArgument
{
    public
    class TanCalculator: IOnearg
    {
        public
           double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Tan(num);
            return (endres);
        }
    }
}
