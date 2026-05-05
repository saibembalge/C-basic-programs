using System;

class Program
{
    static void Main()
    {
        string email = Console.ReadLine();

        if(email.Contains("@") && email.Contains("."))
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}