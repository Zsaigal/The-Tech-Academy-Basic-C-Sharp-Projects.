using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jesse";

            // Concatenating three strings
            string quote = "The man said, \\Hello\", Jesse.  \n Hello on another line. \n \t Hello on a tab.";

            // Using escape character @ to escape any escape characters inside to display file path.
            string filename = @"C:\Users\Jesse";

            // Using Contains() method to determine whether the string contains the letter S
            bool trueOrFalse = quote.Contains("s");

            // whether ends with S using EndsWith() method
            trueOrFalse = name.EndsWith('s');

            // Finding out the number of characters in name
            int length = name.Length;

            // Converting name variable to UpperCase using the Upper() method
            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();

            // Append multiple lines of text to the StringBuilder object, including newlines and a tab
            sb.Append("My name is Jesse.This is a new sentence. \n This is another. \n \t another new sentence on another line with tab using stringbuilder class.");

            // Output the contents of StringBuilder object to the console
            Console.WriteLine(sb);

            // Wait for the user to press a key before closing the console window
            Console.ReadLine();

        }
    }
}
