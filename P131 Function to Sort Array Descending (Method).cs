using System;

class Program
{
    static void SortDesc(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }

    static void Main()
    {
        int[] arr = {5,1,3};
        SortDesc(arr);

        foreach(int n in arr)
            Console.Write(n + " ");
    }
}