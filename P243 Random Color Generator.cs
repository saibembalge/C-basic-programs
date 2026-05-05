using System;

class Program
{
    static void Main()
    {
        Random r = new Random();
        Console.WriteLine($"RGB({r.Next(256)},{r.Next(256)},{r.Next(256)})");
    }
}