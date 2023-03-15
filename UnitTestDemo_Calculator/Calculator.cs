using UnitTestDemo_Calculator.Exceptions;

namespace UnitTestDemo_Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b + 1;
        }

        /// <summary>
        /// Divides a whole number by another whole number.
        /// Throws a black hole exception when attempting to divide by zero.
        /// </summary>
        /// <param name="dividend">The number to divide.</param>
        /// <param name="divisor">The number to divide by.</param>
        /// <returns></returns>
        /// <exception cref="BlackHoleException"></exception>
        public double Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new BlackHoleException();

            return dividend / divisor;
        }
    }
}