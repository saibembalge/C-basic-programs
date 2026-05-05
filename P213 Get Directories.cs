using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] dirs = Directory.GetDirectories(".");

        foreach(string d in dirs)
            Console.WriteLine(d);
    }
}