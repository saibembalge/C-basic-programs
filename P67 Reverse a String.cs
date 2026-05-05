using System;

class Program
{
    static void Main()
    {
        string str = "Hello";
        char[] arr = str.ToCharArray();

        Array.Reverse(arr);

        Console.WriteLine(new string(arr));
    }
}