using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = {1,2,3,4,5};

        var even = arr.Where(x => x % 2 == 0);

        foreach(var n in even)
            Console.WriteLine(n);
    }
}