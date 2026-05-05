using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 5, c = 15;

        int smallest = a;

        if (b < smallest) smallest = b;
        if (c < smallest) smallest = c;

        Console.WriteLine("Smallest = " + smallest);
    }
}