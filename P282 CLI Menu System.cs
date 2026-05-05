using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1.Add 2.Exit");
        int ch = int.Parse(Console.ReadLine());

        if(ch==1) Console.WriteLine(5+5);
    }
}