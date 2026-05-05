using System;

class Program
{
    static void Main()
    {
        int num = 10;
        object obj = num; // boxing

        int n = (int)obj; // unboxing

        Console.WriteLine(n);
    }
}