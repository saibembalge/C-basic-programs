using System;

class Program
{
    static void Main()
    {
        string name = "user";
        Random r = new Random();

        Console.WriteLine(name + "_" + r.Next(1000));
    }
}