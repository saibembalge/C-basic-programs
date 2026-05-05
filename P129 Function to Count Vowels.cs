using System;

class Program
{
    static int CountVowels(string str)
    {
        int count = 0;

        foreach(char c in str)
            if("aeiou".Contains(c)) count++;

        return count;
    }

    static void Main()
    {
        Console.WriteLine(CountVowels("hello"));
    }
}