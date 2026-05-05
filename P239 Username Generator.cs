using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Random r = new Random();
        Console.WriteLine(name + r.Next(100));
    }
}