﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yikes_
{
    public
    class AdditionCalculator: ITwoarg
    {
        public
        double Calculate(double num1, double num2)
        {
            double endres;
            endres = num1 + num2;
            return (endres);
        }

    }
}
