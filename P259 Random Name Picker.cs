using System;

class Program
{
    static void Main()
    {
        string[] names = {"A","B","C","D"};
        Random r = new Random();

        Console.WriteLine(names[r.Next(names.Length)]);
    }
}