using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50, 60 };
        int sum = SumArray(numbers);
        Console.WriteLine(sum);
        Console.WriteLine(sum == 210);
    }

    static int SumArray(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
