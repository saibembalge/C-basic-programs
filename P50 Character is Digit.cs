using System;

class Program
{
    static void Main()
    {
        char ch = '5';

        if(char.IsDigit(ch))
            Console.WriteLine("Digit");
        else
            Console.WriteLine("Not Digit");
    }
}