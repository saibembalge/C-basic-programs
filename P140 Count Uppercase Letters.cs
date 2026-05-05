using System;

class Program
{
    static void Main()
    {
        string str = "HeLLo WorLD";
        int count = 0;

        foreach(char c in str)
        {
            if(char.IsUpper(c))
                count++;
        }

        Console.WriteLine(count);
    }
}