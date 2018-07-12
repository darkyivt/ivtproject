using System;

namespace Yikes_.OneArgument
{
    public
    class CubeCalculator: IOnearg
    {
        public
            double Calculate(double num)
        {
            double endres = 0;
            endres = Math.Pow(num, 3);
            return (endres);
        }
    }
}
