using System;
using System.IO;

class Program
{
    static void Main()
    {
        string text = File.ReadAllText("text_file1.txt");
        text = text.Replace("old","new");
        File.WriteAllText("text_file2.txt", text);
    }
}