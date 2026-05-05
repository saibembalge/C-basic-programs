using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4};

        var result = from n in arr
                     where n > 2
                     select n;

        foreach(var n in result)
            Console.WriteLine(n);
    }
}