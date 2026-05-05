using System;

class Program
{
    static void Main()
    {
        string str = "";

        if(string.IsNullOrEmpty(str))
            Console.WriteLine("String is empty");
        else
            Console.WriteLine("Not empty");
    }
}