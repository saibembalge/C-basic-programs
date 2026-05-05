using System;

class Program
{
    static void Main()
    {
        string str = "programming";
        string result = "";

        foreach(char c in str)
        {
            if(!result.Contains(c))
                result += c;
        }

        Console.WriteLine(result);
    }
}