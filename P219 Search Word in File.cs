using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("test.txt");

        if(text.Contains("Hello"))
            Console.WriteLine("Found");
    }
}