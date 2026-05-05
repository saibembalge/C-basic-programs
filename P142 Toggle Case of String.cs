using System;

class Program
{
    static void Main()
    {
        string str = "HeLLo";
        string result = "";

        foreach(char c in str)
        {
            if(char.IsUpper(c))
                result += char.ToLower(c);
            else
                result += char.ToUpper(c);
        }

        Console.WriteLine(result);
    }
}