using System;

namespace Yikes_.OneArgument
{
    public 
    class LogTenCalculator: IOnearg
    {
        public
            double Calculate(double num1)
        {
            double endres = 0;
            if (num1 == 0)
            {
                throw new Exception("Нулевой логарифм не существует");
            }
            endres = Math.Log(num1, 10);
            return (endres);
        }
    }
}
