using System;

class Program
{
    static void Main()
    {
        int[] arr1 = {1,2,3,4,5};
        int[] arr2 = new int[arr1.Length];

        Array.Copy(arr1, arr2, arr1.Length);

        foreach(int num in arr2)
            Console.Write(num + " ");
    }
}