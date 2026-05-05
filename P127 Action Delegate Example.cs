using System;

class Program
{
    static void Main()
    {
        Action<string> greet = name => Console.WriteLine("Hello " + name);

        greet("Nikhil");
    }
}