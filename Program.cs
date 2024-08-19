using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a constant variable. Its value cannot be changed after it's set.
        const int defaultNumber = 10;

        // This is a variable declared using the 'var' keyword.
        // The type of 'number' is inferred by the compiler as 'int'.
        var number = 5;

        // Create an instance of the NumberHolder class using the default constructor.
        var holder1 = new NumberHolder();

        // Create an instance of the NumberHolder class using the constructor that accepts a number.
        var holder2 = new NumberHolder(number);

        // Display the stored number for each holder.
        Console.WriteLine($"holder1 stores: {holder1.StoredNumber}"); // Outputs: holder1 stores: 10
        Console.WriteLine($"holder2 stores: {holder2.StoredNumber}"); // Outputs: holder2 stores: 5
    }
}

class NumberHolder
{
    public int StoredNumber { get; set; }

    // Default constructor that sets the StoredNumber to the default value.
    public NumberHolder() : this(10) // This constructor calls the next constructor with a default value of 10.
    {
        // No additional initialization needed here.
    }

    // Constructor that accepts an integer and sets it as the StoredNumber.
    public NumberHolder(int number)
    {
        StoredNumber = number; // Set the StoredNumber property to the passed value.
    }
}
