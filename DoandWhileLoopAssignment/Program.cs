using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables
        int x = 5;
        bool condition = true;

        // Perform boolean comparison using a while statement
        while (condition)
        {
            // Check the condition
            if (x > 0)
            {
                Console.WriteLine("x is greater than 0");
                x--; // Decrement x to eventually exit the loop
            }
            else
            {
                condition = false; // Set condition to false to exit the loop
            }
        }

        Console.WriteLine("Loop ended!");


        {  // Initialize variables
            int y = 5;
            bool condition1;

            // Perform boolean comparison using a do-while statement
            do
            {
                // Check the condition
                condition1 = (y > 0);

                if (condition1)
                {
                    Console.WriteLine("y is greater than 0");
                    y--; // Decrement y to eventually exit the loop
                }

            } while (condition1);

            Console.WriteLine("Loop ended!");
        }
    }
}
