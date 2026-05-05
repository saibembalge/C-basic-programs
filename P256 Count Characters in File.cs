using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("text_file1.txt");
        Console.WriteLine(text.Length);
    }
}