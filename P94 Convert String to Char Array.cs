using System;

class Program
{
    static void Main()
    {
        string str = "Hello";

        char[] arr = str.ToCharArray();

        foreach(char c in arr)
            Console.WriteLine(c);
    }
}