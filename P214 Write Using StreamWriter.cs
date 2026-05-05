using System;
using System.IO;

class Program
{
    static void Main()
    {
        using(StreamWriter sw = new StreamWriter("data.txt"))
        {
            sw.WriteLine("Hello File");
        }
    }
}