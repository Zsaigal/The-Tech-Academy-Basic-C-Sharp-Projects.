using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a list of strings with at least two identical strings
        List<string> items = new List<string> { "A", "B", "C", "D", "C" };

        // Create a HashSet to track unique items
        HashSet<string> uniqueItems = new HashSet<string>();

        // Step 2: Use a foreach loop to evaluate each item in the list
        foreach (string item in items)
        {
            // Check if the item has already appeared in the list
            if (uniqueItems.Contains(item))
            {
                // If the item is a duplicate, print a message indicating it is a duplicate
                Console.WriteLine(item + " - this item is a duplicate");
            }
            else
            {
                // If the item is unique, add it to the HashSet and print a message indicating it is unique
                uniqueItems.Add(item);
                Console.WriteLine(item + " - this item is unique");
            }
        }
    }
}
