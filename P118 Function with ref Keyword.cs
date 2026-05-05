using System;

class Program
{
    static void Increment(ref int x)
    {
        x++;
    }

    static void Main()
    {
        int num = 5;
        Increment(ref num);
        Console.WriteLine(num);
    }
}