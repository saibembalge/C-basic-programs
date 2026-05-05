using System;
using System.IO;

class Program
{
    static void Main()
    {
        using(StreamReader sr = new StreamReader("data.txt"))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}