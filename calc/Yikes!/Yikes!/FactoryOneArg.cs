using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
namespace Yikes_
{
    public 
    class FactoryOneArg
    {
        public
            static IOnearg CreateCalculator(string calcname)
        {
            
            switch (calcname)
            {
                case ("bsin"):
                    return new SinCalculator();
                case ("bcos"):
                    return new CosCalculator();
                case ("btan"):
                    return new TanCalculator();
                case ("bln"):
                    return new LnCalculator();
                default: throw new Exception("Неизвестная операция");
            }

            
        }
        
    }
}
