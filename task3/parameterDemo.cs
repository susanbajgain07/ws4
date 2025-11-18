public class ParameterDemo
{
    // 1. Increase method using ref
    public void Increase(ref int number)
    {
        number += 10;
    }

    // 2. GetFullName method using out
    public void GetFullName(out string fullname)
    {
        fullname = "Susan Bajgain";   // you can replace with your name
    }

    // 3. SumAll method using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
