using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,5,30,7,20};
        int min = arr[0];

        foreach(int num in arr)
        {
            if(num < min)
                min = num;
        }

        Console.WriteLine("Smallest = " + min);
    }
}