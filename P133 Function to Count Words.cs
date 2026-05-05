using System;

class Program
{
    static int CountWords(string str)
    {
        return str.Split(' ').Length;
    }

    static void Main()
    {
        Console.WriteLine(CountWords("Hello world"));
    }
}