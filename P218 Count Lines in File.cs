using System;
using System.IO;

class Program
{
    static void Main()
    {
        int count = File.ReadAllLines("multi.txt").Length;
        Console.WriteLine(count);
    }
}