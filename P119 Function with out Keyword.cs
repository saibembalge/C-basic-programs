using System;

class Program
{
    static void GetValues(out int a, out int b)
    {
        a = 10;
        b = 20;
    }

    static void Main()
    {
        int x, y;
        GetValues(out x, out y);

        Console.WriteLine(x + " " + y);
    }
}