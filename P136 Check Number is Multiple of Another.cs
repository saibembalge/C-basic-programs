using System;

class Program
{
    static bool IsMultiple(int a, int b)
    {
        return a % b == 0;
    }

    static void Main()
    {
        Console.WriteLine(IsMultiple(20, 5));
    }
}