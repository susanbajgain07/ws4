using System;

class Program
{
    static void Main(string[] args)
    {
        // Create object of ParameterDemo
        ParameterDemo pd = new ParameterDemo();

        // 1. Calling Increase(ref int)
        int num = 20;
        pd.Increase(ref num);
        Console.WriteLine("After Increase: " + num);

        // 2. Calling GetFullName(out string)
        pd.GetFullName(out string fullName);
        Console.WriteLine("Full Name: " + fullName);

        // 3. Calling SumAll(params int[])
        int total = pd.SumAll(5, 10, 20, 15);
        Console.WriteLine("Sum of values: " + total);

        Console.ReadLine();
    }
}
