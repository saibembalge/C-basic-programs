using System;

class Program
{
    static void Main()
    {
        string t = "Hello world";

        Console.WriteLine("Length: " + t.Length);
        Console.WriteLine("Words: " + t.Split(' ').Length);
    }
}