using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("data.csv");

        foreach(string l in lines)
            Console.WriteLine(l);
    }
}