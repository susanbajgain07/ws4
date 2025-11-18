using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating first student object
        Student s1 = new Student();
        s1.name = "Susan Bajgain";
        s1.age = 20;
        s1.program = "BSc Computing";

        // Creating second student object
        Student s2 = new Student();
        s2.name = "Ram Bahadur";
        s2.age = 21;
        s2.program = "BSc Networking";

        // Displaying values of both objects
        Console.WriteLine("---- Student 1 ----");
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Program: " + s1.program);

        Console.WriteLine("\n---- Student 2 ----");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Program: " + s2.program);

        // Printing static field
        Console.WriteLine("\nCollege Name (Static Field): " + Student.collegeName);

        Console.ReadLine();
    }
}
