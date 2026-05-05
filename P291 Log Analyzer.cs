using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("log.txt");
        Console.WriteLine(lines.Length);
    }
}