using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("renamed.txt");
        int words = text.Split(' ').Length;

        Console.WriteLine(words);
    }
}