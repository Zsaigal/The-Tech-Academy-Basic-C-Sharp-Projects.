using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method with two integer arguments
            mathOps.PerformOperation(10, 5);

            // Call the method with named parameters
            mathOps.PerformOperation(firstNumber: 20, secondNumber: 10);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }

    // Class that contains methods to perform various math operations
    public class MathOperations
    {
        // Method that takes two integers, performs an operation on the first, and displays the second
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform an addition operation on the first number
            int result = firstNumber + 10;

            // Display the result of the operation on the first number
            Console.WriteLine("Result of the operation on the first number: " + result);

            // Display the second number
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }
}
