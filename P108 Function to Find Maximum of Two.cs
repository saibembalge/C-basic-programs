using System;

class Program
{
    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    static void Main()
    {
        Console.WriteLine(Max(10,20));
    }
}