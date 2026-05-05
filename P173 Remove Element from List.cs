using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>(){1,2,3,4};
        list.Remove(2);

        foreach(int n in list)
            Console.WriteLine(n);
    }
}