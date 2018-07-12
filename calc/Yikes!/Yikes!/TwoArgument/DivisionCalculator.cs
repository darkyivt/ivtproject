using System;

namespace Yikes_.TwoArgument
{
    public
    class DivisionCalculator: ITwoarg
    {
        public
           double Calculate(double num1, double num2)
        {
            double endres;
            if (num2 == 0)
            {
                endres = 0;
                throw new Exception("На ноль делить нельзя.");
            }
            return  num1 / num2;
      
        }
    }
}
