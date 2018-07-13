namespace Yikes_.TwoArgument
{
    public
        class AdditionCalculator : ITwoArgument
    {
        /// <summary>
        /// Calculate function addition
        /// </summary>
        /// <param name="FirstArgument1"></param>
        /// <param name="SecondArgument"></param>
        /// <returns>
        /// returns result addition of two argument
        /// </returns>
        public
            double Calculate(double FirstArgument, double SecondArgument)
        {
            double endres;
            endres = FirstArgument + SecondArgument;
            return (endres);
        }

    }
}
