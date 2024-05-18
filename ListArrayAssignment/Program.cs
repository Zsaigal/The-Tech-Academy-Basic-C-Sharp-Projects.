using System;
using System.Collections.Generic;

namespace ArrayAndListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // One-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange", "Grapes", "Pineapple" };

            // Ask the user to select an index of the string array
            Console.WriteLine("Select an index of the string array:");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("String at index " + stringIndex + ": " + stringArray[stringIndex]);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected.");
            }

            // One-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40, 50 };

            // Ask the user to select an index of the integer array
            Console.WriteLine("\nSelect an index of the integer array:");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("Integer at index " + intIndex + ": " + intArray[intIndex]);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected.");
            }

            // List of strings
            List<string> stringList = new List<string> { "Dog", "Cat", "Bird", "Fish", "Rabbit" };

            // Ask the user to select an index of the string list
            Console.WriteLine("\nSelect an index of the string list:");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the selected index is valid
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the string at the selected index
                Console.WriteLine("String at index " + listIndex + ": " + stringList[listIndex]);
            }
            else
            {
                // Display a message for an invalid index
                Console.WriteLine("Invalid index selected.");
            }

            Console.ReadLine(); // Keep console window open
        }
    }
}
