using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] lines = {"Line1","Line2","Line3"};
        File.WriteAllLines("multi.txt", lines);
    }
}