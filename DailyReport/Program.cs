using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the name of the program
        Console.WriteLine("The Tech Academy");

        // Print the title of the report
        Console.WriteLine("Student Daily Report");

        // Ask for the student's name and save it as a string
        Console.Write("What is your name? ");
        string studentName = Console.ReadLine();

        // Ask for the course the student is on and save it as a string
        Console.Write("What course are you on? ");
        string courseName = Console.ReadLine();

        // Ask for the current page number the student is on and save it as an integer
        Console.Write("What page number? ");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        // Ask if the student needs help and save it as a boolean (true/false)
        Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        // Ask for any positive experiences the student would like to share and save it as a string
        Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
        string positiveExperiences = Console.ReadLine();

        // Ask for any additional feedback the student would like to provide and save it as a string
        Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
        string feedback = Console.ReadLine();

        // Ask for the number of hours the student studied today and save it as a float
        Console.Write("How many hours did you study today? ");
        float studyHours = Convert.ToSingle(Console.ReadLine());

        // Print a thank you message
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
    }
}
