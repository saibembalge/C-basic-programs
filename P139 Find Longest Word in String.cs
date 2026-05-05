using System;

class Program
{
    static void Main()
    {
        string str = "CSharp is a powerful language";
        string[] words = str.Split(' ');

        string longest = "";

        foreach(string word in words)
        {
            if(word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine(longest);
    }
}