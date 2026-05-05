using System;

class Program
{
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    static void Main()
    {
        Console.WriteLine(IsEven(7));
    }
}