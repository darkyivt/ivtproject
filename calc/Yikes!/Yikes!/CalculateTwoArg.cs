using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yikes_
{
    public
    class CalculateTwoArg
    {
        public
        double Calculate(object sender, double FirstArgument, double SecondArgument)
        {
            double endres=0;
            MultiplyCalculator mult = new MultiplyCalculator();
            DivisionCalculator div = new DivisionCalculator();
            AdditionCalculator adder = new AdditionCalculator();
            SubstractionCalculator subber = new SubstractionCalculator();
            switch (((Button)sender).Name)
            {
                case ("bplus"): endres = adder.CalcMet(FirstArgument, SecondArgument); break;
                case ("bdiv"): endres = div.CalcMet(FirstArgument, SecondArgument); break;
                case ("bminus"): endres = subber.CalcMet(FirstArgument, SecondArgument); break;
                case ("bmult"): endres = mult.CalcMet(FirstArgument, SecondArgument); break;
                default: throw new Exception("Неизвестная операция");
            }
            return (endres);
        }
    }
}
