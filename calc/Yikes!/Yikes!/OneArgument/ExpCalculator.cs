using System;

namespace Yikes_.OneArgument
{
    public
    class ExpCalculator: IOnearg
    {
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Exp(num);
            return (endres);
        }
    }
}
