using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yikes_
{
    public
        class FactoryTwoArg
    {
        public
            static ITwoarg CreateCalculator(string calcname)
        {
            switch (calcname)
            {
                case ("bplus"):
                    return new AdditionCalculator();
                case ("bdiv"):
                    return new DivisionCalculator();
                case ("bmult"):
                    return new MultiplyCalculator();
                case ("bminus"):
                    return new SubstractionCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }

    }
}
