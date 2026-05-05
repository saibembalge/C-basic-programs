using System;

class Program
{
    static int Max(int[] arr)
    {
        int max = arr[0];

        foreach(int n in arr)
            if(n > max) max = n;

        return max;
    }

    static void Main()
    {
        Console.WriteLine(Max(new int[]{5,10,2}));
    }
}