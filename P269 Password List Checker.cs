using System;

class Program
{
    static void Main()
    {
        string[] list = {"123","abc","pass"};

        string input = Console.ReadLine();

        foreach(string p in list)
        {
            if(p == input)
                Console.WriteLine("Found");
        }
    }
}