using System;
using Yikes_.OneArgument;

namespace Yikes_.TwoArgument
{
    public
        class FactoryTwoArg
    {
        /// <summary>
        /// Create Factory TwoArgumentsFactory
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
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
                case ("bpow"):
                    return new PowCalculator();
                case ("blog"):
                    return new LogCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }

    }
}
