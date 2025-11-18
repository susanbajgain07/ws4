using System;

class Program
{
    static void Main(string[] args)
    {
        // -------- PART 1: ENUM DAYTYPE --------

        // Ask user for the day
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType result; // Variable to store whether it's weekend or weekday

        // Check if the entered day is Friday or Saturday
        if (day == "friday" || day == "Saturday".ToLower())
        {
            result = DayType.Weekend;
        }
        else
        {
            result = DayType.Weekday;
        }

        // Print the result
        Console.WriteLine($"It is: {result}");
        Console.WriteLine("---------------------------------------");

        // -------- PART 2: BOOK RECORD --------

        // Create first book object with fixed values
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 1200);

        // Create second book object using "with" expression
        // Only modify title and price, author stays the same
        Book book2 = book1 with { title = "Rich Dad Poor Dad", price = 950 };

        // Print the first book object's details
        Console.WriteLine("Book 1 Details:");
        Console.WriteLine(book1);
        Console.WriteLine("---------------------------------------");

        // Deconstruct book2 into separate variables
        var (title, author, price) = book2;

        Console.WriteLine("Book 2 (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");

        Console.ReadLine();
    }
}
