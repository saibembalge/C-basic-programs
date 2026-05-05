using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Try block");
        }
        finally
        {
            Console.WriteLine("Finally block");
        }
    }
}