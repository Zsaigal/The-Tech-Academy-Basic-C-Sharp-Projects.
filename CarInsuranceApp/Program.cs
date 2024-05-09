using System;

class Program
{
    static void Main()
    {
        // Ask questions from the applicant
        Console.WriteLine("Car Insurance Approval Program");
        Console.Write("What is your age? ");
        int age = int.Parse(Console.ReadLine()); // Get age from user input

        Console.Write("Have you ever had a DUI? (yes/no) ");
        string duiInput = Console.ReadLine().ToLower(); // Get DUI information from user input
        bool hasDui = duiInput == "yes"; // Convert user input to boolean

        Console.Write("How many speeding tickets do you have? ");
        int speedingTickets = int.Parse(Console.ReadLine()); // Get speeding tickets information from user input

        // Check qualification rules
        bool qualified = age > 15 && !hasDui && speedingTickets <= 3;

        // Print result
        Console.WriteLine("\nQualified for car insurance: " + qualified);
    }
}
