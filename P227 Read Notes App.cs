using System;
using System.IO;

class Program
{
    static void Main()
    {
        if(File.Exists("notes.txt"))
            Console.WriteLine(File.ReadAllText("notes.txt"));
    }
}