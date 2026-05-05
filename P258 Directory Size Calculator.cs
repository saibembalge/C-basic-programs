using System;
using System.IO;

class Program
{
    static void Main()
    {
        long size = 0;

        foreach(string file in Directory.GetFiles("."))
        {
            FileInfo f = new FileInfo(file);
            size += f.Length;
        }

        Console.WriteLine(size);
    }
}