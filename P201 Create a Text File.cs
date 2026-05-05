using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.Create("test.txt").Close();
        Console.WriteLine("File Created");
    }
}