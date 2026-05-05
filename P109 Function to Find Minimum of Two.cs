using System;

class Program
{
    static int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    static void Main()
    {
        Console.WriteLine(Min(5,9));
    }
}