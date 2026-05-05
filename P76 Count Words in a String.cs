using System;

class Program
{
    static void Main()
    {
        string str = "CSharp is a powerful language";
        string[] words = str.Split(' ');

        Console.WriteLine("Word count = " + words.Length);
    }
}