using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {5,3,1,4};

        var sorted = arr.OrderBy(x=>x);

        foreach(var n in sorted)
            Console.WriteLine(n);
    }
}