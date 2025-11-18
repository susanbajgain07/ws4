public class Calculator
{
    // 1. Void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // 2. Add method (with return type)
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // 3. Multiply method (num2 is optional with default value = 1)
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}