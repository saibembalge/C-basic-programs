using System;

class Program
{
    static void Main()
    {
        string text = "abc";
        int shift = 2;
        string result = "";

        foreach(char c in text)
            result += (char)(c + shift);

        Console.WriteLine(result);
    }
}