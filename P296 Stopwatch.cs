using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        Console.ReadLine();

        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }
}