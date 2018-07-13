namespace Yikes_.TwoArgument
{
    public
        class SubstractionCalculator : ITwoarg
    {
        /// <summary>
        /// Calculate Substraction function
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// Check two arguments
        /// <returns>
        /// Result Substraction of two argument
        /// </returns>
        public
            double Calculate(double num1, double num2)
        {
            double endres;
            endres = num1 - num2;
            return (endres);
        }
    }
}
