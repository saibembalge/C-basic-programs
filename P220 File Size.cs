using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileInfo f = new FileInfo("test.txt");
        Console.WriteLine(f.Length);
    }
}