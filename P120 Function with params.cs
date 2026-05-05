using System;

class Program
{
    static int Sum(params int[] nums)
    {
        int sum = 0;
        foreach(int n in nums)
            sum += n;

        return sum;
    }

    static void Main()
    {
        Console.WriteLine(Sum(1,2,3,4));
    }
}