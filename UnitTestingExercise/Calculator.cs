using System;

namespace UnitTestingExercise
{
    public class Calculator
    {
        public int? Add(int? num1, int? num2, int? num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 
        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}