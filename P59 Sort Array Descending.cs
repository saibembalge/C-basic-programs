using System;

class Program
{
    static void Main()
    {
        int[] arr = {5,2,8,1,3};

        Array.Sort(arr);
        Array.Reverse(arr);

        foreach(int num in arr)
            Console.Write(num + " ");
    }
}