using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo_Calculator.Exceptions;

namespace UnitTestDemo_Calculator.Tests
{
    public partial class CalculatorTests
    {
        /// <summary>
        /// Tests for expected exception being thrown.
        /// </summary>
        [Fact]
        public void Divide_WholeNumberByZero_BlackHoleException1()
        {
            // Arrange
            var calculator = new Calculator();
            int dividend = 1;
            int divisor = 0;

            // Act & Assert
            Assert.Throws<BlackHoleException>(() => calculator.Divide(dividend, divisor));
        }

        /// <summary>
        /// Tests for expected exception being thrown while adhering more strictly to the AAA format.
        /// </summary>
        [Fact]
        public void Divide_WholeNumberByZero_BlackHoleException2()
        {
            // Arrange
            var calculator = new Calculator();
            int dividend = 1;
            int divisor = 0;

            // Act
            // Action act = () => calculator.Divide(dividend, divisor);
            void act() => calculator.Divide(dividend, divisor);

            // Assert
            Assert.Throws<BlackHoleException>(act);
        }

        /// <summary>
        /// Tests for expected message in thrown exception. 
        /// </summary>
        [Fact]
        public void Divide_WholeNumberByZero_BlackHoleException3()
        {
            // Arrange
            var calculator = new Calculator();
            int dividend = 1;
            int divisor = 0;
            string expected = "What have you done?";

            // Act
            void act() => calculator.Divide(dividend, divisor);
            Exception ex = Assert.Throws<BlackHoleException>(act);
            string actual = ex.Message;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
