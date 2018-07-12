using System;

namespace Yikes_.OneArgument
{
    public
    class ModCalculator: IOnearg
    {
            public
                double Calculate(double num)
            {
                double endres = 0;
                endres = Math.Abs(num);
                return (endres);
            }
        }
}
