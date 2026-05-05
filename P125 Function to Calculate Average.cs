using System;

class Program
{
    static double Avg(int[] arr)
    {
        int sum = 0;
        foreach(int n in arr) sum += n;

        return (double)sum / arr.Length;
    }

    static void Main()
    {
        Console.WriteLine(Avg(new int[]{10,20,30}));
    }
}