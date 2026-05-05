using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3};

        var square = arr.Select(x => x * x);

        foreach(var n in square)
            Console.WriteLine(n);
    }
}