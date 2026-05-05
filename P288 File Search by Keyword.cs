using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("new_text_file1.txt");

        if(text.Contains("data"))
            Console.WriteLine("Found");
    }
}