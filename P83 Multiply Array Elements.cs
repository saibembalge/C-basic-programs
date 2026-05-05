using System;

class Program
{
    static void Main()
    {
        int[] arr = {2,3,4};
        int product = 1;

        foreach(int num in arr)
            product *= num;

        Console.WriteLine(product);
    }
}