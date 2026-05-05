using System;

class Program
{
    static void Main()
    {
        string[] quotes = {"Stay strong","Keep learning","Never give up"};
        Random r = new Random();

        Console.WriteLine(quotes[r.Next(quotes.Length)]);
    }
}