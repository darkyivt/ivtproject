using System;

namespace Yikes_.OneArgument
{
    public
    class LnCalculator: IOnearg
    {
        public 
           double Calculate(double num)
        {
            double endres = 0;
            if (num == 0)
            {
                throw new Exception("Нулевой логарифм не существует");
            }
            endres = Math.Log(num);
            return (endres);
        }
    }
}
