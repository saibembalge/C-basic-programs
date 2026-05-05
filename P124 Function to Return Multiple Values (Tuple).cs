using System;

class Program
{
    static (int,int) GetNumbers()
    {
        return (10,20);
    }

    static void Main()
    {
        var (a,b) = GetNumbers();
        Console.WriteLine(a + " " + b);
    }
}