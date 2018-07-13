using System;

namespace Yikes_.OneArgument
{
    public class Arccos : IOneArgument
    {
        /// <summary>
        /// Calculates  Arccos(x) function
        /// </summary>
        /// <param name="num"></param>
        /// Check firstArgument
        /// if firstArgument more than 1 or first argument less than -1
        /// then error
        /// <returns>
        /// Return function Arccos (x)
        /// </returns>
        public double Calculate(double FirstArgument)
        {
            if (FirstArgument > 1 || FirstArgument < -1)
            {
                throw new Exception("Недопустимое значение");
            }

            return Math.Acos(FirstArgument);
        }
    }
}
