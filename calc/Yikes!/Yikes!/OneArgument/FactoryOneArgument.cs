using System;

namespace Yikes_.OneArgument
{
    public static class FactoryOneArgument
    {
        /// <summary>
        /// Create Factory FactoryOneArg
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public
            static IOneArgument CreateCalculator(string calculatorName)
        {

            switch (calculatorName)
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
                case ("barccos"):
                    return new Arccos();
                case ("barcctg"):
                    return new ArcCtg();
                case ("barcsin"):
                    return new ArcSin();
                case ("barctan"):
                    return new ArcTan();
                case ("bfivestep"):
                    return new Fivestep();
                case ("brad"):
                    return new Radical();
                case ("brevers"):
                    return new ReverseNumber();
                case ("bsqrt"):
                    return new Sqrt();
                case ("btanh"):
                    return new TanH();
                default: throw new Exception("Неизвестная операция");
            }


        }

    }
}