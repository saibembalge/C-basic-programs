using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var lines = File.ReadAllLines("file.txt").OrderBy(x=>x);
        File.WriteAllLines("file.txt", lines);
    }
}