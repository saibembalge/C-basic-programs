using System;
using System.IO;

class Program
{
    static void Main()
    {
        foreach(string l in File.ReadAllLines("file.txt"))
        {
            if(l.Contains("error"))
                Console.WriteLine(l);
        }
    }
}