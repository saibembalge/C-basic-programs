using System;

class Program
{
    static void Main()
    {
        Predicate<int> isEven = x => x % 2 == 0;

        Console.WriteLine(isEven(4));
    }
}