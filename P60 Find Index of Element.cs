using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40};

        int index = Array.IndexOf(arr,30);

        Console.WriteLine(index);
    }
}