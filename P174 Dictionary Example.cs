using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int,string> d = new Dictionary<int,string>();
        d[1] = "One";
        d[2] = "Two";

        Console.WriteLine(d[1]);
    }
}