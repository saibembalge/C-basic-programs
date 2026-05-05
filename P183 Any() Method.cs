using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,3,5};

        Console.WriteLine(arr.Any(x => x % 2 == 0));
    }
}