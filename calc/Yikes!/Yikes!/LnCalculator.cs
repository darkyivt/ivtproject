using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

namespace Yikes_
{
    public
    class LnCalculator: IOnearg
    {
        public 
           double Calculate(double num)
        {
            double endres = 0;
            endres = Log(num);
            return (endres);
        }
    }
}
