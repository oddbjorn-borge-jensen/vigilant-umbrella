using UnitTestDemo_Calculator.Exceptions;

namespace UnitTestDemo_Calculator.Tests
{
    public partial class CalculatorTests
    {
        /// <summary>
        /// Tests a method for expected behaviour given a certain state.
        /// </summary>
        [Fact]
        public void Add_FourAndFour_Eight() // MethodName_StateUnderTest_ExpectedBehaviour
        {
            // Arrange
            var calculator = new Calculator();
            int leftOperand = 4;
            int rightOperand = 4;
            int expected = leftOperand + rightOperand;   // NO MAGIC VARIABLES!!

            // Act
            int actual = calculator.Add(leftOperand, rightOperand);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_TwoAndTwo_Four()
        {
            // Arrange
            var calculator = new Calculator();
            int num1 = 2;
            int num2 = 2;
            int expected = num1 + num2;

            // Act 
            int actual = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}