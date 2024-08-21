using System;

namespace TryCatchAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int currentYear = DateTime.Now.Year;
            
            try
            {
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                   {
                    Console.WriteLine("Age must be a positive number!");
                   }
                   else
                   {
                    Console.WriteLine("You were born in {0}", currentYear - age);
                   }                  
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number for your age");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.{ex.Message}");
            }
            
        }
    }
}
