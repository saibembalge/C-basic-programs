using System;
using System.IO;

class Program
{
    static void Main()
    {
        File.AppendAllText("test.txt", "\nNew Line");
    }
}