using System;
using System.Collections;
using System.Linq;
using System.Text;



namespace ConsoleApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Takes an input from the user
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();

                // Multiplies the input by 50
                // Parses the input string to a double
                double number = double.Parse(userInput);
                double result = number * 50;

                // Prints the result to the console
                Console.WriteLine($"Result of multiplying {userInput} by 50: {result}");

                // Takes an input from the user
                Console.WriteLine("Enter another number:");
                userInput = Console.ReadLine();

                // Adds 25 to the input
                // Parses the input string to a double
                number = double.Parse(userInput);
                result = number + 25;

                // Prints the result to the console
                Console.WriteLine($"Result of adding 25 to {userInput}: {result}");

                // Takes an input from the user
                Console.WriteLine("Enter another number:");
                userInput = Console.ReadLine();

                // Divides the input by 12.5
                // Parses the input string to a double
                number = double.Parse(userInput);
                result = number / 12.5;

                // Prints the result to the console
                Console.WriteLine($"Result of dividing {userInput} by 12.5: {result}");

                // Takes an input from the user
                Console.WriteLine("Enter another number:");
                userInput = Console.ReadLine();

                // Parses the input string to a double
                number = double.Parse(userInput);

                // Checks if the input is greater than 50
                bool isGreaterThan50 = number > 50;

                // Prints the true/false result to the console
                Console.WriteLine($"Is {userInput} greater than 50? {isGreaterThan50}");

                // Takes an input from the user
                Console.WriteLine("Enter another number:");
                userInput = Console.ReadLine();

                // Parses the input string to a double
                number = double.Parse(userInput);

                // Divides the input by 7 and calculates the remainder
                double remainder = number % 7;

                // Prints the remainder to the console
                Console.WriteLine($"Remainder of dividing {userInput} by 7: {remainder}");

                // Waits for user input before closing the console window
                Console.ReadLine();
            }
        }
    }

