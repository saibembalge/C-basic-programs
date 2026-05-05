using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        names.Add("A");
        names.Add("B");

        Console.WriteLine(string.Join(",", names));
    }
}