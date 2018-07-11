using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yikes_
{
    class CalculateOneArg
    {
        public
            double Calculate(object sender, double Argument)
        {
            double endres = 0;
            LnCalculator ln = new LnCalculator();
            TanCalculator tg = new TanCalculator();
            SinCalculator sinc = new SinCalculator();
            CosCalculator cosc = new CosCalculator();
            switch (((Button)sender).Name)
            {
                case ("bsin"): endres = sinc.CalcSin(Argument); break;
                case ("bcos"): endres = cosc.CalcCos(Argument); break;
                case ("btan"): endres = tg.CalcTan(Argument); break;
                case ("bln"): endres = ln.CalcLog(Argument); break;
                default: throw new Exception("Неизвестная операция");
            }
            return (endres);
        }
    }
}
