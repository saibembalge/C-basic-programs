using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,50,30,70,20};
        int max = arr[0];

        foreach(int num in arr)
        {
            if(num > max)
                max = num;
        }

        Console.WriteLine("Largest = " + max);
    }
}