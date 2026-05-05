using System;

class Program
{
    static void Main()
    {
        char ch = 's';

        if ("aeiouAEIOU".Contains(ch))
            Console.WriteLine("Vowel");
        else
            Console.WriteLine("Consonant");
    }
}