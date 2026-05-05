using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,2,3,3,4};

        var unique = arr.Distinct();

        foreach(var n in unique)
            Console.Write(n + " ");
    }
}