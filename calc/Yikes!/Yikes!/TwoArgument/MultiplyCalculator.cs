namespace Yikes_.TwoArgument
{
    public
        class MultiplyCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function Multiply
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// <param name="SecondArgument"></param>
        /// Check two arguments
        /// <returns>
        ///  Result Multiply of two argument
        /// </returns>
        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres;
            endres = FirstArgument * SecondArgument;
            return (endres);
        }
    }
}

