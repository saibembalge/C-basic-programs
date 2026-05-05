using System;

class Program
{
    static void Main()
    {
        int[] arr = {3,6,9,12};
        int sum = 0;

        for(int i=0;i<arr.Length;i++)
            sum += arr[i];

        Console.WriteLine(sum);
    }
}