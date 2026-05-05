using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {2,4,6};

        Console.WriteLine(arr.All(x => x % 2 == 0));
    }
}