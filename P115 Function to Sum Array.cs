using System;

class Program
{
    static int Sum(int[] arr)
    {
        int sum = 0;
        foreach(int n in arr)
            sum += n;

        return sum;
    }

    static void Main()
    {
        int[] arr = {1,2,3};
        Console.WriteLine(Sum(arr));
    }
}