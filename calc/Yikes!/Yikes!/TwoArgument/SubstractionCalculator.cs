namespace Yikes_.TwoArgument
{
    public
        class SubstractionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate Substraction function
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// Check two arguments
        /// <returns>
        /// Result Substraction of two argument
        /// </returns>
        public
            double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}
