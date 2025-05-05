using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(3, 7, 3, 13)]
        [InlineData(7, 9, 17, 33)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(3, null, 3, null)]
        [InlineData(44, 0, 1, 45)]
        public void AddTest(int? num1, int? num2, int? num3, int? expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Add(num1, num2, num3);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, -3)]
        [InlineData(3, 7, -4)]
        [InlineData(7, 1, 6)]
        [InlineData(12, 3, 9)]
        [InlineData(53, 7, 46)]
        [InlineData(7, 9, -2)]
        public void SubtractTest(int minend, int subtrahend, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Subtract(minend, subtrahend);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(3, 7, 21)]
        [InlineData(7, 1, 7)]
        [InlineData(12, 3, 36)]
        [InlineData(5, 7, 35)]
        [InlineData(7, 9, 63)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Multiply(num1, num2);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 3, 0)]
        [InlineData(8, 4, 2)]
        [InlineData(7, 1, 7)]
        [InlineData(12, 3, 4)]
        [InlineData(49, 7, 7)]
        [InlineData(20, 2, 10)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(dividend, divisor);
            Assert.Equal(expected, actual);
        }
    }
}