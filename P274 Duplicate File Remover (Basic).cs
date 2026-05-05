using System;
using System.IO;

class Program
{
    static void Main()
    {
        if(File.Exists("copy.txt"))
            File.Delete("copy.txt");
    }
}