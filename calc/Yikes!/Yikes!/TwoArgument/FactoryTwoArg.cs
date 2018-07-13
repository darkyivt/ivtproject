using System;

namespace Yikes_.TwoArgument
{
    public
        class FactoryTwoArguments
    {
        /// <summary>
        /// Create Factory TwoArgumentsFactory
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
        public
            static ITwoArgument CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
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
