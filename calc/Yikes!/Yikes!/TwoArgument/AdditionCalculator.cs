namespace Yikes_.TwoArgument
{
    public
        class AdditionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function addition
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// returns result addition of two argument
        /// </returns>
        public
            double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }

    }
}
