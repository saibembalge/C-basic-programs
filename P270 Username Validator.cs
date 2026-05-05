using System;

class Program
{
    static void Main()
    {
        string user = Console.ReadLine();

        if(user.Length >= 5)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}