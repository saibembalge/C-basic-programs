using System;

class Program
{
    static void Main()
    {
        string str = "education";
        int count = 0;

        foreach(char c in str)
        {
            if("aeiou".Contains(c))
                count++;
        }

        Console.WriteLine(count);
    }
}