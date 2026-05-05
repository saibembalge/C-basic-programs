using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40};

        for(int i=arr.Length-1;i>=0;i--)
            Console.WriteLine(arr[i]);
    }
}