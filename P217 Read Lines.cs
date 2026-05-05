using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("multi.txt");

        foreach(string l in lines)
            Console.WriteLine(l);
    }
}