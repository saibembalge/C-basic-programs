using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("test.txt");
        Console.WriteLine(text);
    }
}