namespace Yikes_.TwoArgument
{
    public
        class AdditionCalculator : ITwoarg
    {
        /// <summary>
        /// Calculate function addition
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>
        /// returns result addition of two argument
        /// </returns>
        public
            double Calculate(double num1, double num2)
        {
            double endres;
            endres = num1 + num2;
            return (endres);
        }

    }
}
