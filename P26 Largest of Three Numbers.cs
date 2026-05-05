using System;

class Program
{
    static void Main()
    {
        int a = 10, b = 25, c = 15;

        int largest = a;

        if (b > largest) largest = b;
        if (c > largest) largest = c;

        Console.WriteLine("Largest = " + largest);
    }
}