namespace Yikes_.TwoArgument
{
    public
        class SubstractionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate Substraction function
        /// </summary>
        /// <param name="FirstArgument"></param>
        /// <param name="SecondArgument"></param>
        /// Check two arguments
        /// <returns>
        /// Result Substraction of two argument
        /// </returns>
        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres;
            endres = FirstArgument - SecondArgument;
            return (endres);
        }
    }
}
