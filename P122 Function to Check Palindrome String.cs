using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return str == new string(arr);
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome("madam"));
    }
}