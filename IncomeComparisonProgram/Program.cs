using System;

class Program
{
    static void Main()
    {
        // Print the title of the program
        Console.WriteLine("Anonymous Income Comparison Program");

        // Get details for Person 1
        Console.WriteLine("Person 1");
        Console.Write("Enter hourly rate: ");
        double hourlyRate1 = double.Parse(Console.ReadLine()); // Get hourly rate from user input
        Console.Write("Enter hours worked per week: ");
        double hoursPerWeek1 = double.Parse(Console.ReadLine()); // Get hours worked per week from user input

        // Calculate annual salary for Person 1
        double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52; // Assuming 52 weeks in a year

        // Get details for Person 2
        Console.WriteLine("\nPerson 2");
        Console.Write("Enter hourly rate: ");
        double hourlyRate2 = double.Parse(Console.ReadLine()); // Get hourly rate from user input
        Console.Write("Enter hours worked per week: ");
        double hoursPerWeek2 = double.Parse(Console.ReadLine()); // Get hours worked per week from user input

        // Calculate annual salary for Person 2
        double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52; // Assuming 52 weeks in a year

        // Print annual salaries for both persons
        Console.WriteLine("\nAnnual salary of Person 1: " + annualSalary1);
        Console.WriteLine("Annual salary of Person 2: " + annualSalary2);

        // Compare annual salaries and print result
        Console.WriteLine("\nDoes Person 1 make more money than Person 2? " + (annualSalary1 > annualSalary2));
    }
}
