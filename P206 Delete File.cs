using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Delete("test.txt");
        Console.WriteLine("Deleted");
    }
}