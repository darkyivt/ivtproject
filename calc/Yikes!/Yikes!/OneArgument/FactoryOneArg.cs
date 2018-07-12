using System;

namespace Yikes_.OneArgument
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
                case ("bsquare"):
                    return new SquareCalculator();
                case ("bcube"):
                    return new CubeCalculator();
                case ("bexp"):
                    return new ExpCalculator();
                case ("bl10"):
                    return new LogTenCalculator();
                case ("bmod"):
                    return new ModCalculator();
                default: throw new Exception("Неизвестная операция");
            }

            
        }
        
    }
}
