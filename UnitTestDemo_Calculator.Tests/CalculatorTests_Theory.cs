using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo_Calculator.Tests
{
    public partial class CalculatorTests
    {
        /// <summary>
        /// Theory testing a set of data provided using InlineData.
        /// </summary>
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 3, 5)]
        [InlineData(7, -1, 6)]
        public void Add_WholeNumbers_ExpectedSums1(int leftAddend, int rightAddend, int sum)
        {
            // Arrange
            var calculator = new Calculator();
            int expected = sum;

            // Act
            int actual = calculator.Add(leftAddend, rightAddend);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Data set used to test a theory using MemberData.
        /// </summary>
        public static TheoryData<int, int, int> CalculatorAddTheoryData => new()
        {
            { 1, 1, 2 },
            { 2, 3, 5 },
            { 7, -1, 6 }
        };

        /// <summary>
        /// Theory testing a set of data provided using MemberData (reference to a static field, property, or method).
        /// </summary>
        [Theory]
        [MemberData(nameof(CalculatorAddTheoryData))]
        public void Add_WholeNumbers_ExpectedSums2(int leftAddend, int rightAddend, int sum)
        {
            // Arrange
            var calculator = new Calculator();
            int expected = sum;

            // Act
            int actual = calculator.Add(leftAddend, rightAddend);

            // Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Theory testing a set of data provided by using ClassData (reference to a class that implements IEnumerable<object[]>, in this case IEnumerable<int[]>).
        /// </summary>
        [Theory]
        [ClassData(typeof(MyVeryFirstTheoryData))]
        public void Add_WholeNumbers_ExpectedSums3(int leftAddend, int rightAddend, int sum)
        {
            // Arrange
            var calculator = new Calculator();
            int expected = sum;

            // Act
            int actual = calculator.Add(leftAddend, rightAddend);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
