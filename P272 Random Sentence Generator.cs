using System;

class Program
{
    static void Main()
    {
        string[] s = {"I write code","You have to learn","We must grow"};
        Random r = new Random();

        Console.WriteLine(s[r.Next(s.Length)]);
    }
}