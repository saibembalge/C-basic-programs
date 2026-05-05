using System;
using System.IO;

class Program
{
    static void Main()
    {
        if(File.Exists("test.txt"))
            Console.WriteLine("File Exists");
        else
            Console.WriteLine("File Not Found");
    }
}