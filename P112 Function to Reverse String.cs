using System;

class Program
{
    static string Reverse(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static void Main()
    {
        Console.WriteLine(Reverse("Hello"));
    }
}