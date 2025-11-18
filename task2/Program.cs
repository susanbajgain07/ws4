using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create object of Calculator
        Calculator calc = new Calculator();

        // Calling the welcome method
        calc.PrintWelcome();

        // Calling Add()
        int sum = calc.Add(10, 20);

        // Calling Multiply() – using default parameter
        int result1 = calc.Multiply(5);        // num2 = 1 automatically

        // Calling Multiply() – providing both parameters
        int result2 = calc.Multiply(5, 4);

        // Printing results
        Console.WriteLine("Addition Result: " + sum);
        Console.WriteLine("Multiply with default value: " + result1);
        Console.WriteLine("Multiply with two values: " + result2);
    }
}