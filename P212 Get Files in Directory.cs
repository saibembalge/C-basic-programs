using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] files = Directory.GetFiles(".");

        foreach(string f in files)
            Console.WriteLine(f);
    }
}