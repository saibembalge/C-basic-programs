using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string pass = Console.ReadLine();

        if(pass.Length >= 8)
            Console.WriteLine("Strong");
        else
            Console.WriteLine("Weak");
    }
}