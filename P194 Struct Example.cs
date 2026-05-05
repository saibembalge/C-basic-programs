using System;

struct Point
{
    public int x, y;
}

class Program
{
    static void Main()
    {
        Point p;
        p.x = 10;
        p.y = 20;

        Console.WriteLine(p.x + "," + p.y);
    }
}