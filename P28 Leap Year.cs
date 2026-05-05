using System;

class Program
{
    static void Main()
    {
        int year = 2026;

        if (year % 4 == 0)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not Leap Year");
    }
}