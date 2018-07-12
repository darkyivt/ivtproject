using System;

namespace Yikes_.OneArgument
{
    public
    class CosCalculator : IOnearg
    {
        public
        double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Cos(num);
            return (endres);
        }
    }
}
