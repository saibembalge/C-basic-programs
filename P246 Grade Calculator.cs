using System;

class Program
{
    static void Main()
    {
        int marks = int.Parse(Console.ReadLine());

        if(marks>=90) Console.WriteLine("A");
        else if(marks>=75) Console.WriteLine("B");
        else Console.WriteLine("C");
    }
}